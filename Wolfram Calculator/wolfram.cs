using System;
using System.Drawing;
using Wolfram.NETLink;

namespace Wolfram_Calculator
{
    internal class wolfram
    {
        //It seems very redundant to keep repeating yourself like this, but all the other ways I've tried just make the app freeze at some point and I don't want to spend an eternity on this.

        public static string[] evaluate(string equation)
        {
            //So I'll explain how this works only once:
            //We create a Kernel link between the Mathematica Kernel and our program. Another class, IMathLink, can also be used to create links, but when
            //working with specifically the Mathematica Kernel, we should use IKernelLink because it is much eaiser and simpler.
            IKernelLink ml = MathLinkFactory.CreateKernelLink();
            //The Kernel sends us garbage data. It will always send us garbage whenever we first establish a link, we discard this data.
            ml.WaitAndDiscardAnswer();
            //Can be done better? I dislike wasting memory. There are different Evaluation methods, the difference is in the type of variable we get as a result.
            string[] result = { ml.EvaluateToOutputForm("Solve[" + equation + ", x]", 0) };
            //Make sure to CLOSE THE KERNEL when you are done using it or else it will REMAIN OPEN, even when other instances are opened!
            ml.Close();
            return result;
        }

        public static Image graph(string equation)
        {
            IKernelLink ml = MathLinkFactory.CreateKernelLink();
            ml.WaitAndDiscardAnswer();
            Image result = ml.EvaluateToImage("Plot[" + equation + ", {x, -10, 10}]", 500, 500);
            ml.Close();
            return result;
        }
        public static Image graph3d(string equation)
        {
            IKernelLink ml = MathLinkFactory.CreateKernelLink();
            ml.WaitAndDiscardAnswer();
            Image result = ml.EvaluateToImage("Plot3D[" + equation + ", {x, -10, 10}, {y,-10,10}]", 500, 500);
            ml.Close();
            return result;
        }

        public static string derive(string equation)
        {
            IKernelLink ml = MathLinkFactory.CreateKernelLink();
            ml.WaitAndDiscardAnswer();
            string result = ml.EvaluateToInputForm("D[" + equation + "]", 0);
            ml.Close();
            return result;
        }

        public static string integrate(string equation)
        {
            IKernelLink ml = MathLinkFactory.CreateKernelLink();
            ml.WaitAndDiscardAnswer();
            string result = ml.EvaluateToInputForm("Integrate[" + equation + "]", 0);
            ml.Close();
            return result;
        }
    }
}

using System;

namespace BMIConsole
{
    public class BMICalcular
    {
        public BMICalcular()
        {
        }

        internal string Calc(SexType sexType, decimal height, decimal weight)
        {
            //bmi = 體重 / (身高公尺)^2
            decimal bmi = weight / ((height / 100m) * (height / 100m));

            if (sexType == SexType.Man)
                return ManBmiRsult(bmi);
            else
                return WomanBmiResult(bmi);
        }

        private string WomanBmiResult(decimal bmi)
        {
            if (bmi < 18)
                return "太瘦";
            else if (bmi > 22)
                return "太胖";
            return "適中";
        }

        private string ManBmiRsult(decimal bmi)
        {
            if (bmi < 20)
                return "太瘦";
            else if (bmi > 25)
                return "太胖";
            return "適中";
        }
    }
}
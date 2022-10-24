using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_BMI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 輸入身高(m)、體重(kg)
			double height = 1.65;
			double weight = 80.3;

			// 計算BMI值，BMIValculator(身高, 體重)
			double bmIndex = BMICalculator(height, weight);

			// 以BMI值，推論身體指標是否符合標準
			string result = BMIStandard(bmIndex);
			// 呈現BMI值和標準
			Console.WriteLine($"BMI = {bmIndex.ToString("0.##")} \r\n" +
				$"體重是{result}");
		}
		public static double BMICalculator (double height, double weight)
		{
			double bmi = weight / (height * height);
			return bmi;
		}
		public static string BMIStandard (double bmIndex)
		{
			string result = string.Empty;
			if (bmIndex < 18.5)
			{ result = "過輕"; }
			else if (bmIndex < 24)
			{ result = "標準"; }
			else if (bmIndex < 27)
			{ result = "過重"; }
			else if (bmIndex < 30)
			{ result = "輕度肥胖"; }
			else if (bmIndex < 35)
			{ result = "中度肥胖"; }
			else if (bmIndex >= 35)
			{ result = "重度肥胖"; }
			return result;
		}
	}
}

//using System;
//class TelerikVideo
//{
//    static void Main()
//    {
//        string inputLIne = Console.ReadLine();
//        while (inputLIne != "-1")
//        {
//            uint inputNumber = uint.Parse(inputLIne);
//            char[] currentNumbeBinaryDigits = Convert.ToString(inputNumber, 2)
//                .PadLeft(32, '0').ToCharArray();

//            bool isInsideNeuron = false;
//            bool isOnBoundary = false;
//            bool beenInNeuron = false;
//            for (int i = 0; i < currentNumbeBinaryDigits.Length; i++)
//            {
//                if (currentNumbeBinaryDigits[i] == '1')
//                {
//                    isOnBoundary = true;
//                    currentNumbeBinaryDigits[i] = '0';
//                    if (isInsideNeuron)
//                    {
//                        isInsideNeuron = false;
//                        beenInNeuron = true;
//                    }
//                }
//                else
//                {
//                    if (!beenInNeuron && isOnBoundary)
//                    {
//                        isInsideNeuron = true;
//                        isOnBoundary = false;
//                    }
//                    if (isInsideNeuron)
//                    {
//                        currentNumbeBinaryDigits[i] = '1';
//                    }
//                }
//            }
//            if (!beenInNeuron)
//            {
//                Console.WriteLine(0);
//            }
//            else
//            {
//                UInt32 resulNumber = Convert.ToUInt32(new string(currentNumbeBinaryDigits), 2);
//                Console.WriteLine(resulNumber);
//            }
//            inputLIne = Console.ReadLine();
//        }
//    }
//}

using System.Text;

public class JoyofHex
{
    static void Main(string[] args)
    {
        /**************************************************************************************
         * Problem: 
         * Given one hex literal with a long data type signed.
         * Given a second hex literal with an int data type signed. Add the two together. 
         * What will be the answer when the program is run?
         *  0x100000000L
         * + 0xCAFEBABE
         * -------------
         * 0x1CAFEBABE
         * 
         * The program uses long arithmetic, which permits 16 hex digits, so arithmetic overflow is not an issue. 
         * Yet, if you ran the program, you found that it prints CAFEBABE, with no leading 1 digit. 
         * This output represents the low-order 32 bits of the correct sum, but somehow the thirty-third bit gets lost. 
         * It is as if the program were doing int arithmetic instead of long, or forgetting to add the first operand. 
         * What’s going on here?
         * 
         * 
         **************************************************************************************/

        string hexString = "100000000"; //operand_one

        string hex = "CAFEBABE"; //operand_two

        long operand_one = long.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine();
        Console.WriteLine("Operand One as hex string is: 0x" + operand_one.ToString("X"));
        
        int operand_two = Int32.Parse(hex, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine();
        Console.WriteLine("Operand Two as hex string is: 0x" + operand_two.ToString("X"));
        Console.WriteLine();
        Console.WriteLine("operand_one: long.Parse(hexString, System.Globalization.NumberStyles.HexNumber)");
        Console.WriteLine("operand_two: Int32.Parse(hex, System.Globalization.NumberStyles.HexNumber)");
        Console.WriteLine();
        long total = operand_one + operand_two;
        Console.WriteLine("Let's add both operands together and see what we get...Note that we're adding an int to a long");
        Console.WriteLine();
        Console.WriteLine("Operand One + Operand Two is: " + total.ToString("X") + ". WTH! We expected 1CAFEBABE. What happened to the 1?");
        Console.WriteLine();

        //to get the correct answer, cast the second operand to long:
        long operand_twotwo = Int64.Parse(hex, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine("To get the correct answer, just convert the right operand to a long hex literal and you get the expected answer");
        total = operand_one + operand_twotwo;
        Console.WriteLine("Operand One + Operand Two is: " + total.ToString("X"));

        int decimalvalue = Int32.Parse(hex, System.Globalization.NumberStyles.HexNumber);

        Console.WriteLine("Hex literal 0xCAFEBABE with a bit depth of 64 bits equals {0} decimal.", 0xcafebabe);
        
        Console.WriteLine("Hex literal 0xCAFEBABE with a bit depth of 32 bits equals {0} decimal.", decimalvalue);

        Console.WriteLine();

        Console.WriteLine("Hex literal 0x100000000 with a bit depth of 64 bits equals {0} decimal.", 0x100000000L);

    }
}
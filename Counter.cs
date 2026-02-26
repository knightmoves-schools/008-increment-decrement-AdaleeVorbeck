namespace knightmoves;
public class Counter
{
    public static int Visitors = 100;
    // Add your code here
    public int PrefixIncrement;
    public int PostfixIncrement;
    public int PrefixDecrement;
    public int PostfixDecrement;
    public Counter()
    {
        PrefixIncrement = ++Visitors;
        PostfixIncrement = Visitors++;
        PrefixDecrement = --Visitors;
        PostfixDecrement = Visitors--;
    }
}

//should assign the prefix incremented value of Visitors to a class-level variable named PrefixIncrement
//should assign the postfix incremented value of Visitors to a class-level variable named PostfixIncrement
//should assign the prefix decrement value of Visitors to a class-level variable named PrefixDecrement
//should assign the postfix decrement value of Visitors to a class-level variable named PostfixDecrement
//should have a final value of 100 stored in the variable Visitors
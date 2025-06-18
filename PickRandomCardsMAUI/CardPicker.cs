namespace PickRandomCards;

internal class CardPicker
{
    public static string[] PickSomeCards(int numberOfCards)
    {
        string[] pickedCards = new string[numberOfCards];
        for (int i = 0; i < numberOfCards; i++)
        {
            pickedCards[i] = RandomValue() + " of " + RandomSuit();
        }
        return pickedCards;
    }

    private static string RandomSuit()
    {
        int value = Random.Shared.Next(1, 5);
        switch (value)
        {
            case 1: return "Spades";
            case 2: return "Hearts";
            case 3: return "Clubs";
            case 4: return "Diamonds";
            default: return "error"; //or throw new InvalidOperationException("Unexpected suit value: " + value);
        }
    }

    private static string RandomValue()
    {
        int value = Random.Shared.Next(1, 14);
        switch (value)
        {
            case 1: return "Ace";
            case 11: return "Jack";
            case 12: return "Queen";
            case 13: return "King";
            default: return value.ToString();
        }
    }
}

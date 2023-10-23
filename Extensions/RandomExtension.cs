using System;

namespace Marigolds;

public static class RandomExtension
{
  private const string letters = "abcdefghijklmnopqrstuvwxyz";
  private const string symbols = @"!@#$%^&*()-_=+[]{};:'"",<>/?|`";

  public static int GetDigit(this Random random)
    => random.Next(0, 10);

  public static char GetLetter(this Random random)
    => letters[random.Next(0, letters.Length)];

  public static char GetSymbol(this Random random)
    => symbols[random.Next(0, symbols.Length)];
}


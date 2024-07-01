namespace Blind150.Arrays___Hashing;

public class ValidSudoku
{
    private static int squareSize = 3;
    public bool IsValidSudoku(char[][] board)
    {
        var horizontalValid = Enumerable.Range(0, board.Length).All(i => !hasDuplicate(board[i].Where(c => c != '.')));
        bool verticalValid = true, squareValid = true;
        for (int i = 0; i < board.Length; ++i)
        {
            var column = Enumerable.Range(0, board.Length).Select(j => board[j][i]).Where(c => c != '.');
            verticalValid &= !hasDuplicate(column);
        }

        int squareCount = board.Length / squareSize;
        for (int i = 0; i < squareCount; ++i)
        {
            for (int j = 0; j < squareCount; ++j)
            {
                int topLeftX = squareSize * i;
                int topLeftY = squareSize * j;
                var square = Enumerable.Range(0, squareSize).SelectMany(
                    iX => Enumerable.Range(0, squareSize).Select(iY => board[topLeftX + iX][topLeftY + iY]))
                    .Where(c => c != '.');
                squareValid &= !hasDuplicate(square);
            }
        }
        return horizontalValid && verticalValid && squareValid;
    }
    
    public bool hasDuplicate(IEnumerable<char> input)
    {
        HashSet<char> set = new HashSet<char>();
        return input.Any(t => !set.Add(t));
    }
}
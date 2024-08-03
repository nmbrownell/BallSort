
using System;
using System.Linq;
using System.Collections.Generic;
using HelloWold;

namespace HelloWold;

public static class Program
{
    const int NUM_TUBES = 15;
    const int NUM_THREADS = 100;

    public static void Main()
    {
        int numGames = 0;
        bool isGameWon = false;

        Thread[] threads = new Thread[NUM_THREADS];

        for (int i = 0; i < NUM_THREADS; i++)
        {
            Thread.Sleep(2); // Make sure the seeds are spaced apart

            threads[i] = new Thread(() =>
            {
                Tube[] game = new Tube[NUM_TUBES];
                int seed = DateTime.Now.Millisecond;
                Random rand = new Random(seed);

                do
                {
                    string gameText = ("\nStarting New Game \n");

                    for (int j = 0; j < NUM_TUBES; j++)
                    {
                        game[j] = new Tube();
                    }

                    // 506
                    //game[0].balls.AddRange(new Color[] { Color.LIGHTBLUE, Color.LIGHTGREEN, Color.YELLOW, Color.PURPLE, Color.WHITE });
                    //game[1].balls.AddRange(new Color[] { Color.YELLOW, Color.BROWN, Color.LIGHTGREEN, Color.BROWN, Color.BLUE });
                    //game[2].balls.AddRange(new Color[] { Color.GREEN, Color.WHITE, Color.GREEN, Color.WHITE, Color.TEAL });
                    //game[3].balls.AddRange(new Color[] { Color.LIGHTBLUE, Color.RED, Color.BROWN, Color.PINK, Color.ORANGE });
                    //game[4].balls.AddRange(new Color[] { Color.RED, Color.PURPLE, Color.ORANGE, Color.MAGENTA, Color.MAGENTA });
                    //game[5].balls.AddRange(new Color[] { Color.ORANGE, Color.LIGHTGREEN, Color.MAGENTA, Color.PURPLE, Color.LIGHTGREEN });
                    //game[6].balls.AddRange(new Color[] { Color.TEAL, Color.YELLOW, Color.PURPLE, Color.GREEN, Color.PINK });
                    //game[7].balls.AddRange(new Color[] { Color.PINK, Color.TEAL, Color.BLUE, Color.ORANGE, Color.WHITE });
                    //game[8].balls.AddRange(new Color[] { Color.MAGENTA, Color.RED, Color.BROWN, Color.LIGHTBLUE, Color.MAGENTA });
                    //game[9].balls.AddRange(new Color[] { Color.LIGHTGREEN, Color.PINK, Color.GREEN, Color.RED, Color.PURPLE });
                    //game[10].balls.AddRange(new Color[] { Color.BLUE, Color.LIGHTBLUE, Color.BROWN, Color.PINK, Color.BLUE });
                    //game[11].balls.AddRange(new Color[] { Color.TEAL, Color.YELLOW, Color.BLUE, Color.TEAL, Color.GREEN });
                    //game[12].balls.AddRange(new Color[] { Color.YELLOW, Color.RED, Color.WHITE, Color.ORANGE, Color.LIGHTBLUE });

                    // 505
                    game[0].balls.AddRange(new Color[] { Color.BROWN, Color.MAGENTA, Color.ORANGE, Color.PURPLE, Color.RED });
                    game[1].balls.AddRange(new Color[] { Color.YELLOW, Color.LIGHTBLUE, Color.ORANGE, Color.MAGENTA, Color.RED });
                    game[2].balls.AddRange(new Color[] { Color.BLUE, Color.TEAL, Color.LIGHTBLUE, Color.LIGHTGREEN, Color.MAGENTA });
                    game[3].balls.AddRange(new Color[] { Color.MAGENTA, Color.BLUE, Color.BROWN, Color.TEAL, Color.GREEN });
                    game[4].balls.AddRange(new Color[] { Color.GREEN, Color.PURPLE, Color.RED, Color.PURPLE, Color.GREEN });
                    game[5].balls.AddRange(new Color[] { Color.GREEN, Color.PINK, Color.MAGENTA, Color.LIGHTGREEN, Color.LIGHTGREEN });
                    game[6].balls.AddRange(new Color[] { Color.RED, Color.WHITE, Color.YELLOW, Color.ORANGE, Color.WHITE });
                    game[7].balls.AddRange(new Color[] { Color.BLUE, Color.LIGHTBLUE, Color.PINK, Color.TEAL, Color.BROWN });
                    game[8].balls.AddRange(new Color[] { Color.RED, Color.PURPLE, Color.LIGHTGREEN, Color.YELLOW, Color.YELLOW });
                    game[9].balls.AddRange(new Color[] { Color.LIGHTGREEN, Color.WHITE, Color.BLUE, Color.ORANGE, Color.WHITE });
                    game[10].balls.AddRange(new Color[] { Color.ORANGE, Color.WHITE, Color.TEAL, Color.BROWN, Color.BLUE });
                    game[11].balls.AddRange(new Color[] { Color.TEAL, Color.PINK, Color.BROWN, Color.PURPLE, Color.PINK });
                    game[12].balls.AddRange(new Color[] { Color.GREEN, Color.LIGHTBLUE, Color.PINK, Color.YELLOW, Color.LIGHTBLUE });

                    // 504
                    //game[0].balls.AddRange(new Color[] { Color.BLUE, Color.YELLOW, Color.YELLOW, Color.YELLOW, Color.PINK });
                    //game[1].balls.AddRange(new Color[] { Color.LIGHTGREEN, Color.LIGHTGREEN, Color.LIGHTBLUE, Color.GREEN, Color.BROWN });
                    //game[2].balls.AddRange(new Color[] { Color.LIGHTGREEN, Color.TEAL, Color.ORANGE, Color.ORANGE, Color.BLUE });
                    //game[3].balls.AddRange(new Color[] { Color.RED, Color.BLUE, Color.MAGENTA, Color.MAGENTA, Color.RED });
                    //game[4].balls.AddRange(new Color[] { Color.ORANGE, Color.BLUE, Color.TEAL, Color.GREEN, Color.BROWN });
                    //game[5].balls.AddRange(new Color[] { Color.LIGHTBLUE, Color.TEAL, Color.PINK, Color.RED, Color.GREEN });
                    //game[6].balls.AddRange(new Color[] { Color.GREEN, Color.YELLOW, Color.BROWN, Color.TEAL, Color.RED });
                    //game[7].balls.AddRange(new Color[] { Color.TEAL, Color.LIGHTBLUE, Color.RED, Color.PURPLE, Color.BROWN });
                    //game[8].balls.AddRange(new Color[] { Color.PURPLE, Color.PURPLE, Color.LIGHTGREEN, Color.MAGENTA, Color.PINK });
                    //game[9].balls.AddRange(new Color[] { Color.BROWN, Color.LIGHTBLUE, Color.BLUE, Color.WHITE, Color.LIGHTGREEN });
                    //game[10].balls.AddRange(new Color[] { Color.MAGENTA, Color.ORANGE, Color.LIGHTBLUE, Color.PURPLE, Color.WHITE });
                    //game[11].balls.AddRange(new Color[] { Color.PURPLE, Color.PINK, Color.GREEN, Color.ORANGE, Color.WHITE });
                    //game[12].balls.AddRange(new Color[] { Color.WHITE, Color.YELLOW, Color.PINK, Color.WHITE, Color.MAGENTA });

                    bool gameLost = false;
                    while (!IsGameWon(game) && !gameLost)
                    {
                        List<Move> moves = GetAllMoves(game);
                        if (moves.Count() == 0)
                        {
                            gameLost = true;
                        }
                        else
                        {
                            Move move = moves[(int)rand.NextInt64(0, moves.Count())];

                            gameText += String.Format("Moving {0} to {1}.\n", move.source, move.target);
                            game[move.source].MoveTo(game[move.target]);
                        }
                    }

                    if (IsGameWon(game))
                    {
                        isGameWon = true;
                        gameText += "Game won\n";
                    }
                    else
                    {
                        gameText = "No more moves. Game Lost.\n";
                    }

                    lock (numGames as object)
                    {
                        numGames++;
                        gameText += String.Format("Games Played: {0}\n", numGames);
                        Console.WriteLine(gameText);
                    }

                } while (!isGameWon);
            });
            threads[i].Start();
        }


    }

    static bool IsGameWon(Tube[] game)
    {
        foreach (Tube tube in game)
        {
            if (tube.balls.Count() != 0)
            {
                if (tube.balls.Count() != 5)
                {
                    return false;
                }
                else
                {
                    Color first = tube.balls[0];
                    foreach (Color ball in tube.balls)
                    {
                        if (first != ball)
                        {
                            return false;
                        }
                    }
                }
            }
        }
        return true;
    }

    static List<Move> GetAllMoves(Tube[] game)
    {
        List<Move> moves = new List<Move>();

        for (int i = 0; i < NUM_TUBES; i++)
        {
            for (int j = 0; j < NUM_TUBES; j++)
            {
                if (i != j)
                {
                    if (!game[i].IsDone() && game[i].CanEmpty(game))
                    {
                        if (game[i].CanMoveTo(game[j]) > 0)
                        {
                            moves.Add(new Move(i, j));
                        }
                    }
                }
            }
        }
        return moves;
    }
}

public enum Color
{
    PINK,
    MAGENTA,
    LIGHTBLUE,
    BLUE,
    GREEN,
    BROWN,
    RED,
    ORANGE,
    PURPLE,
    YELLOW,
    TEAL,
    LIGHTGREEN,
    WHITE,
}

public class Move
{
    public int source;
    public int target;

    public Move(int s, int t)
    {
        source = s;
        target = t;
    }
}

public class Tube
{
    public int maxNum = 5;

    public List<Color> balls = new List<Color>();

    public bool IsDone()
    {
        if (balls.Count() != maxNum)
        {
            return false;
        }

        bool allSame = true;

        for (int i = 1; i < maxNum; i++)
        {
            if(balls[i] != balls[0])
            {
                allSame = false;
            }
        }

        return allSame;
    }

    public int CanMoveTo(Tube target)
    {
        if (balls.Count() == 0)
        {
            return 0;
        }

        if (target.balls.Count() == 0)
        {
            int numPlaced = 0;
            while (numPlaced != this.balls.Count() && this.balls[this.balls.Count() - 1 - numPlaced] == this.balls.Last() & target.balls.Count() + numPlaced <= maxNum)
            {
                numPlaced++;
            }
            return numPlaced;
        }

        if (target.balls.Count() >= target.maxNum)
        {
            return 0;
        }

        if (target.balls.Last() == this.balls.Last())
        {
            int numPlaced = 0;
            while (numPlaced != this.balls.Count() && this.balls[this.balls.Count() - 1 - numPlaced] == this.balls.Last() && target.balls.Count() + numPlaced <= maxNum)
            {
                numPlaced++;
            }
            return numPlaced;
        }

        return 0;
    }

    public bool CanEmpty(Tube[] game)
    {
        if (balls.Count() == 0)
        {
            return true;
        }
        
        int numToPlace = 0;

        while (numToPlace < this.balls.Count() && this.balls[this.balls.Count() - 1 - numToPlace] == this.balls.Last())
        {
            numToPlace++;
        }

        foreach (Tube tube in game)
        {
            if (this != tube)
            {
                if (tube.balls.Count() == 0)
                {
                    return true;
                }
                if (tube.balls.Last() == this.balls.Last())
                {
                    int vacant = maxNum - tube.balls.Count();
                    numToPlace -= vacant;

                    if (numToPlace <= 0)
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }

    public void MoveTo(Tube target)
    {
        while (CanMoveTo(target) > 0)
        {
            Color temp = balls.Last();
            this.balls.RemoveAt(balls.Count() - 1);
            target.balls.Add(temp);
        }
    }
}

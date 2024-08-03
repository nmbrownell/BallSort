# Why does this exist?
I spent 2 months on level 505 of this specific variant of the ball sort game: https://play.google.com/store/apps/details?id=com.spicags.ballsort
I couldn't solve it. The reason? It's impossible. And this program proves it by simulating games until a solution is found. Even after 100M games, level 505 can't be done without an extra tube. 

Levels 506 and 504 are also included as proof that this does work.

# Environment
Built in Visual Studio Community 2022
Targets .Net8.0

# How to Use
1. Open `Program.cs`
2. Change `NUM_THREADS` to your preference. The default of 100 should maximize performance on most CPUs.
3. Uncomment the game you want to simulate. Just be sure to only leave one uncommmented at a time.

The number of tubes can be adjusted if you want to add an extra one. This will allow you to solve level 505. The number of balls per tube is currently hard coded at 5, but this would be fairly trival to change if necessary.

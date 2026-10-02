<div align="center">

# Tetris — WPF Desktop Game

<p>
  A classic Tetris implementation built with C#, .NET 6, and Windows Presentation Foundation (WPF).
</p>

<p>
  <a href="https://github.com/MOHAMMAD-KIMIA/Tetris-Project">
    <img src="https://img.shields.io/badge/Repository-GitHub-181717?style=for-the-badge&logo=github" alt="GitHub Repository">
  </a>
  <img src="https://img.shields.io/badge/C%23-.NET%206-512BD4?style=for-the-badge&logo=.net" alt="C# .NET 6">
  <img src="https://img.shields.io/badge/WPF-Desktop%20Application-68217A?style=for-the-badge" alt="WPF">
  <img src="https://img.shields.io/badge/Architecture-OOP-2E7D32?style=for-the-badge" alt="Object Oriented Programming">
</p>

</div>

<hr>

<h2>Overview</h2>

<p>
  <strong>Tetris</strong> is a desktop implementation of the classic block-stacking
  game developed using <strong>C#</strong>, <strong>.NET 6</strong>, and
  <strong>Windows Presentation Foundation (WPF)</strong>.
</p>

<p>
  The project focuses on implementing the core mechanics of Tetris while applying
  fundamental software engineering and object-oriented programming concepts.
  The game includes piece generation, movement, rotation, collision detection,
  line clearing, scoring, increasing difficulty, hold functionality, next-piece
  preview, and ghost-piece rendering.
</p>

<p>
  The project was designed not only as a playable game, but also as an exercise
  in designing reusable game components, managing application state, implementing
  algorithms, and separating game logic from the presentation layer.
</p>

<hr>

<h2>Key Features</h2>

<table>
  <tr>
    <td width="50%">

### Gameplay

* Seven standard Tetromino pieces
* Piece movement
* Clockwise rotation
* Counter-clockwise rotation
* Soft drop
* Hard drop
* Collision detection
* Line clearing
* Game-over detection

    </td>
    <td width="50%">

### Advanced Mechanics

* Hold piece system
* Next piece preview
* Ghost piece
* Increasing fall speed
* Dynamic game loop
* Score tracking
* Multiple rotation states
* Random piece generation

    </td>
  </tr>

</table>

<hr>

<h2>Game Board</h2>

<p>
  The game uses a <strong>22 × 10</strong> grid as its main playfield.
  Each cell represents one position that can either be empty or occupied by
  part of a Tetromino.
</p>

<pre>
+--------------------+
|                    |
|                    |
|                    |
|                    |
|                    |
|                    |
|                    |
|                    |
|                    |
|                    |
|                    |
|                    |
|                    |
|                    |
|                    |
|                    |
|                    |
|                    |
|                    |
|                    |
|                    |
|                    |
+--------------------+
       10 Columns
       22 Rows
</pre>

<p>
  The grid is represented internally using a two-dimensional array, allowing
  the game to efficiently check occupied cells, detect collisions, and clear
  completed rows.
</p>

<hr>

<h2>Tetrominoes</h2>

<p>
  The game implements all seven standard Tetris pieces.
  Each piece inherits from the common <code>Block</code> abstraction and defines
  its own rotation states.
</p>

<table>
  <thead>
    <tr>
      <th>Piece</th>
      <th>Class</th>
      <th>Description</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>I</td>
      <td><code>IBlock</code></td>
      <td>Long four-cell straight piece</td>
    </tr>
    <tr>
      <td>J</td>
      <td><code>JBlock</code></td>
      <td>Three-cell horizontal piece with one additional cell</td>
    </tr>
    <tr>
      <td>L</td>
      <td><code>LBlock</code></td>
      <td>Three-cell horizontal piece with one additional cell</td>
    </tr>
    <tr>
      <td>O</td>
      <td><code>OBlock</code></td>
      <td>Two-by-two square piece</td>
    </tr>
    <tr>
      <td>S</td>
      <td><code>SBlock</code></td>
      <td>Zig-zag shaped piece</td>
    </tr>
    <tr>
      <td>T</td>
      <td><code>TBlock</code></td>
      <td>T-shaped piece</td>
    </tr>
    <tr>
      <td>Z</td>
      <td><code>ZBlock</code></td>
      <td>Reverse zig-zag shaped piece</td>
    </tr>
  </tbody>
</table>

<hr>

<h2>Game Controls</h2>

<table>
  <thead>
    <tr>
      <th>Input</th>
      <th>Action</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td><kbd>←</kbd></td>
      <td>Move piece left</td>
    </tr>
    <tr>
      <td><kbd>→</kbd></td>
      <td>Move piece right</td>
    </tr>
    <tr>
      <td><kbd>↓</kbd></td>
      <td>Soft drop</td>
    </tr>
    <tr>
      <td><kbd>↑</kbd></td>
      <td>Rotate clockwise</td>
    </tr>
    <tr>
      <td><kbd>Z</kbd></td>
      <td>Rotate counter-clockwise</td>
    </tr>
    <tr>
      <td><kbd>C</kbd></td>
      <td>Hold current piece</td>
    </tr>
    <tr>
      <td><kbd>Space</kbd></td>
      <td>Hard drop</td>
    </tr>
  </tbody>
</table>

<hr>

<h2>Game Architecture</h2>

<p>
  The application is structured around independent classes responsible for
  different parts of the game system.
</p>

<pre>
                         +----------------+
                         |   MainWindow   |
                         |   WPF / XAML   |
                         +-------+--------+
                                 |
                                 v
                         +----------------+
                         |    GameState   |
                         +-------+--------+
                                 |
          +----------------------+----------------------+
          |                      |                      |
          v                      v                      v
   +-------------+        +-------------+        +-------------+
   |  GameGrid   |        | BlockQueue  |        | Current     |
   |             |        |             |        | Block       |
   +-------------+        +-------------+        +-------------+
                                 |
                                 v
                         +----------------+
                         |    Block       |
                         +-------+--------+
                                 |
          +------+------+------+------+------+------+------+
          |      |      |      |      |      |      |
          v      v      v      v      v      v      v
          I      J      L      O      S      T      Z
</pre>

<hr>

<h2>Core Components</h2>

<h3>GameState</h3>

<p>
  <code>GameState</code> acts as the central controller for the gameplay state.
  It coordinates the active piece, grid, score, held piece, next piece,
  movement, rotation, and game progression.
</p>

<h3>GameGrid</h3>

<p>
  <code>GameGrid</code> represents the board and provides the underlying
  structure used for collision detection, block placement, row clearing,
  and board state management.
</p>

<h3>Block</h3>

<p>
  <code>Block</code> provides the common abstraction for Tetromino pieces.
  Individual pieces extend this abstraction and provide their own rotation
  configurations.
</p>

<h3>BlockQueue</h3>

<p>
  The block queue manages upcoming Tetromino pieces and provides the next
  piece used by the game.
</p>

<h3>Position</h3>

<p>
  The <code>Position</code> structure is used to represent coordinates within
  the game grid and determine where each block cell should be rendered.
</p>

<hr>

<h2>Game Mechanics</h2>

<h3>Piece Movement</h3>

<p>
  The active Tetromino can move horizontally across the board.
  Every movement is validated against the current grid before the position
  is updated.
</p>

<h3>Collision Detection</h3>

<p>
  Before a piece is moved or rotated, its target cells are checked against
  the boundaries of the board and existing occupied cells.
</p>

<p>
  This prevents pieces from moving outside the playable area or overlapping
  with blocks that have already been placed.
</p>

<h3>Rotation</h3>

<p>
  Each Tetromino contains predefined rotation states.
  The game changes the active rotation state when the player rotates a piece
  and validates the resulting position before applying the rotation.
</p>

<h3>Hard Drop</h3>

<p>
  The hard-drop mechanic calculates the maximum valid downward distance and
  immediately places the current piece at that position.
</p>

<h3>Soft Drop</h3>

<p>
  Soft drop allows the player to accelerate the downward movement of the
  current Tetromino.
</p>

<h3>Line Clearing</h3>

<p>
  After a Tetromino is placed, the grid is scanned for completed rows.
  Full rows are removed and the remaining blocks are shifted downward.
</p>

<h3>Ghost Piece</h3>

<p>
  The ghost piece displays the position where the current Tetromino would
  land if dropped immediately.
  The implementation uses the calculated block drop distance to determine
  the ghost position.
</p>

<h3>Hold System</h3>

<p>
  The player can store the current Tetromino using the <kbd>C</kbd> key.
  The implementation uses a hold-state flag to prevent repeatedly holding
  pieces without first placing the active piece.
</p>

<hr>

<h2>Scoring System</h2>

<p>
  The current scoring implementation increases the score according to the
  number of rows cleared during gameplay.
</p>

<pre>
Score += ClearedRows;
</pre>

<p>
  The scoring system is intentionally simple and can be extended in the
  future to support standard Tetris scoring rules, combo bonuses, T-Spins,
  back-to-back clears, and level multipliers.
</p>

<hr>

<h2>Increasing Difficulty</h2>

<p>
  The falling speed of the Tetrominoes increases as the game progresses.
  The game uses a configurable delay system:
</p>

<table>
  <thead>
    <tr>
      <th>Parameter</th>
      <th>Value</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>Maximum Delay</td>
      <td>1000 ms</td>
    </tr>
    <tr>
      <td>Minimum Delay</td>
      <td>75 ms</td>
    </tr>
    <tr>
      <td>Delay Reduction</td>
      <td>25 ms</td>
    </tr>
  </tbody>
</table>

<p>
  This creates a progressively faster gameplay experience as the player
  continues playing.
</p>

<hr>

<h2>Game Loop</h2>

<p>
  The game uses an asynchronous loop to control automatic piece movement.
  The loop periodically waits according to the current fall delay and then
  attempts to move the active piece downward.
</p>

<pre>
Start Game
    |
    v
Create / Select Block
    |
    v
Render Block
    |
    v
Wait for Fall Delay
    |
    v
Try Move Down
    |
    +---- Success ----> Continue Loop
    |
    +---- Collision
             |
             v
        Lock Block
             |
             v
        Clear Rows
             |
             v
        Update Score
             |
             v
        Spawn Next Block
             |
             v
        Check Game Over
</pre>

<hr>

<h2>Rendering System</h2>

<p>
  The user interface is implemented using WPF and XAML.
  The game board is rendered through a WPF <code>Canvas</code> and a collection
  of image controls representing individual grid cells.
</p>

<p>
  Rendering responsibilities include:
</p>

<ul>
  <li>Drawing the game grid</li>
  <li>Drawing the active Tetromino</li>
  <li>Drawing the ghost piece</li>
  <li>Displaying the next Tetromino</li>
  <li>Displaying the held Tetromino</li>
  <li>Updating the game board after every state change</li>
</ul>

<hr>

<h2>Object-Oriented Design</h2>

<p>
  The project applies several fundamental object-oriented programming concepts.
</p>

<table>
  <thead>
    <tr>
      <th>Concept</th>
      <th>Application</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>Abstraction</td>
      <td>The <code>Block</code> class defines common Tetromino behavior.</td>
    </tr>
    <tr>
      <td>Inheritance</td>
      <td>Individual Tetromino classes inherit from the base block abstraction.</td>
    </tr>
    <tr>
      <td>Polymorphism</td>
      <td>Different Tetromino implementations provide their own configurations.</td>
    </tr>
    <tr>
      <td>Encapsulation</td>
      <td>Game state and block behavior are maintained within dedicated classes.</td>
    </tr>
    <tr>
      <td>Separation of Concerns</td>
      <td>Game logic, state management, and UI rendering are handled separately.</td>
    </tr>
  </tbody>
</table>

<hr>

<h2>Algorithms and Data Structures</h2>

<ul>
  <li>Two-dimensional arrays for board representation</li>
  <li>Coordinate-based block positioning</li>
  <li>Collision detection</li>
  <li>Grid traversal for completed-row detection</li>
  <li>Row shifting after line clearing</li>
  <li>Randomized Tetromino generation</li>
  <li>Drop-distance calculation</li>
  <li>State-based gameplay management</li>
</ul>

<hr>

<h2>Project Structure</h2>

<pre>
Tetris-Project/
│
├── Blocks/
│   ├── Block.cs
│   ├── IBlock.cs
│   ├── JBlock.cs
│   ├── LBlock.cs
│   ├── OBlock.cs
│   ├── SBlock.cs
│   ├── TBlock.cs
│   └── ZBlock.cs
│
├── GameGrid.cs
├── GameState.cs
├── BlockQueue.cs
├── Position.cs
├── Context.cs
├── Service.cs
├── savedata.cs
│
├── MainWindow.xaml
├── MainWindow.xaml.cs
│
├── App.xaml
├── App.xaml.cs
│
└── Tetris-Project.csproj
</pre>

<hr>

<h2>Technology Stack</h2>

<table>
  <thead>
    <tr>
      <th>Technology</th>
      <th>Purpose</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>C#</td>
      <td>Application and game logic</td>
    </tr>
    <tr>
      <td>.NET 6</td>
      <td>Application runtime and framework</td>
    </tr>
    <tr>
      <td>WPF</td>
      <td>Desktop user interface</td>
    </tr>
    <tr>
      <td>XAML</td>
      <td>User interface definition</td>
    </tr>
    <tr>
      <td>Entity Framework Core</td>
      <td>Database infrastructure</td>
    </tr>
    <tr>
      <td>SQL Server / LocalDB</td>
      <td>Database infrastructure</td>
    </tr>
    <tr>
      <td>Git</td>
      <td>Version control</td>
    </tr>
    <tr>
      <td>GitHub</td>
      <td>Source code hosting</td>
    </tr>
  </tbody>
</table>

<hr>

<h2>Getting Started</h2>

<h3>Prerequisites</h3>

<ul>
  <li>Windows operating system</li>
  <li>.NET 6 SDK</li>
  <li>Visual Studio 2022 or another compatible .NET IDE</li>
</ul>

<h3>Clone the Repository</h3>

<pre>
git clone https://github.com/MOHAMMAD-KIMIA/Tetris-Project.git
cd Tetris-Project
</pre>

<h3>Restore Dependencies</h3>

<pre>
dotnet restore
</pre>

<h3>Run the Application</h3>

<pre>
dotnet run
</pre>

<p>
  Alternatively, open the solution in Visual Studio and run the project
  using the standard WPF debugging configuration.
</p>

<hr>

<h2>Gameplay Flow</h2>

<ol>
  <li>The game initializes the board and piece queue.</li>
  <li>A Tetromino is selected as the active piece.</li>
  <li>The active piece is rendered on the board.</li>
  <li>The game loop automatically moves the piece downward.</li>
  <li>The player can move or rotate the piece.</li>
  <li>The player can use hold, soft drop, or hard drop.</li>
  <li>When downward movement is no longer possible, the piece is locked.</li>
  <li>Completed rows are detected and removed.</li>
  <li>The score is updated.</li>
  <li>The next Tetromino becomes active.</li>
  <li>The board is checked for game-over conditions.</li>
</ol>

<hr>

<h2>Database Integration</h2>

<p>
  The project contains database-related infrastructure using
  <strong>Entity Framework Core</strong> and SQL Server / LocalDB components.
</p>

<p>
  This part of the project provides a foundation for persistent game-related
  data. However, database persistence is not currently the primary focus of
  the application and can be further refined as a future improvement.
</p>

<hr>

<h2>Current Limitations</h2>

<ul>
  <li>Scoring does not currently implement the complete official Tetris scoring system.</li>
  <li>The rotation system can be extended with a complete wall-kick implementation.</li>
  <li>The random piece generator can be improved using the standard seven-bag system.</li>
  <li>Automated unit and integration tests are limited.</li>
  <li>Persistent high-score management can be improved.</li>
  <li>The UI can be further refined with animations and additional visual feedback.</li>
</ul>

<hr>

<h2>Future Improvements</h2>

<table>
  <thead>
    <tr>
      <th>Area</th>
      <th>Planned Improvement</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>Gameplay</td>
      <td>Implement complete Tetris scoring and combo mechanics</td>
    </tr>
    <tr>
      <td>Rotation</td>
      <td>Add a full wall-kick system</td>
    </tr>
    <tr>
      <td>Randomization</td>
      <td>Implement seven-bag Tetromino randomization</td>
    </tr>
    <tr>
      <td>Persistence</td>
      <td>Implement persistent high scores and player statistics</td>
    </tr>
    <tr>
      <td>Audio</td>
      <td>Add sound effects and background music</td>
    </tr>
    <tr>
      <td>UI</td>
      <td>Add animations and improved visual feedback</td>
    </tr>
    <tr>
      <td>Testing</td>
      <td>Add unit and integration tests</td>
    </tr>
    <tr>
      <td>Architecture</td>
      <td>Further separate game logic from presentation concerns</td>
    </tr>
  </tbody>
</table>

<hr>

<h2>Testing Strategy</h2>

<p>
  The game can be tested through a combination of manual gameplay testing
  and automated tests for isolated game components.
</p>

<h3>Important Test Cases</h3>

<ul>
  <li>Piece movement at the left and right board boundaries</li>
  <li>Piece collision with existing blocks</li>
  <li>Piece collision with the bottom of the board</li>
  <li>Clockwise and counter-clockwise rotation</li>
  <li>Hard-drop positioning</li>
  <li>Ghost-piece calculation</li>
  <li>Hold-piece restrictions</li>
  <li>Single-row clearing</li>
  <li>Multiple-row clearing</li>
  <li>Game-over detection</li>
  <li>Increasing fall speed</li>
</ul>

<hr>

<h2>Learning Outcomes</h2>

<p>
  This project provided practical experience in:
</p>

<ul>
  <li>Object-oriented software design</li>
  <li>C# application development</li>
  <li>WPF desktop application development</li>
  <li>XAML-based UI development</li>
  <li>Game-state management</li>
  <li>Algorithm implementation</li>
  <li>Collision detection</li>
  <li>Two-dimensional grid manipulation</li>
  <li>Asynchronous programming</li>
  <li>Software architecture</li>
  <li>Version control with Git</li>
</ul>

<hr>

<h2>Academic Context</h2>

<p>
  The project was developed as a practical software engineering and
  object-oriented programming project. It demonstrates how fundamental
  programming concepts can be combined to build an interactive desktop
  application with non-trivial state management and algorithmic logic.
</p>

<hr>

<h2>Repository</h2>

<div align="center">

<p>
  <a href="https://github.com/MOHAMMAD-KIMIA/Tetris-Project">
    <img src="https://img.shields.io/badge/View%20Source%20Code-GitHub-181717?style=for-the-badge&logo=github" alt="View Source Code">
  </a>
</p>

<p>
  <strong>GitHub:</strong>
  <a href="https://github.com/MOHAMMAD-KIMIA/Tetris-Project">
    MOHAMMAD-KIMIA/Tetris-Project
  </a>
</p>

</div>

<hr>

<div align="center">

<h3>Author</h3>

<p>
  <strong>Mohammad Kimia</strong>
</p>

<p>
  Computer Engineering Student<br>
  Software Development &amp; Artificial Intelligence
</p>

<p>
  <a href="https://github.com/MOHAMMAD-KIMIA">
    GitHub
  </a>
</p>

</div>

<div align="center">

# Tetris

<p>
  A desktop Tetris game built with <strong>C#</strong>, <strong>.NET 6</strong>, and <strong>WPF</strong>.
</p>

<p>
  <img src="https://img.shields.io/badge/C%23-.NET%206-512BD4?style=for-the-badge&logo=csharp&logoColor=white" alt="C# .NET 6">
  <img src="https://img.shields.io/badge/WPF-Desktop%20Application-68217A?style=for-the-badge" alt="WPF">
  <img src="https://img.shields.io/badge/XAML-UI-0C54C2?style=for-the-badge" alt="XAML">
  <img src="https://img.shields.io/badge/OOP-Architecture-2E7D32?style=for-the-badge" alt="OOP">
</p>

<p>
  <a href="https://github.com/MOHAMMAD-KIMIA/Tetris-Project">
    View Repository
  </a>
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
  fundamental object-oriented programming and software engineering concepts.
  It includes Tetromino generation, movement, rotation, collision detection,
  line clearing, scoring, increasing fall speed, hold functionality,
  next-piece preview, and ghost-piece rendering.
</p>

<p>
  The main goal of the project was to build a complete interactive desktop
  application while practicing game-state management, grid-based algorithms,
  reusable class design, inheritance, polymorphism, and asynchronous programming.
</p>

<hr>

<h2>Features</h2>

<table>
  <tr>
    <td width="50%" valign="top">

<h3>Core Gameplay</h3>

<ul>
  <li>Seven standard Tetromino pieces</li>
  <li>Horizontal piece movement</li>
  <li>Clockwise rotation</li>
  <li>Counter-clockwise rotation</li>
  <li>Soft drop</li>
  <li>Hard drop</li>
  <li>Collision detection</li>
  <li>Line clearing</li>
  <li>Game-over detection</li>
</ul>

```
</td>
<td width="50%" valign="top">
```

<h3>Additional Mechanics</h3>

<ul>
  <li>Next piece preview</li>
  <li>Hold piece functionality</li>
  <li>Ghost piece</li>
  <li>Dynamic falling speed</li>
  <li>Score tracking</li>
  <li>Predefined rotation states</li>
  <li>Random piece generation</li>
  <li>Asynchronous game loop</li>
</ul>

```
</td>
```

  </tr>
</table>

<hr>

<h2>Game Controls</h2>

<table>
  <thead>
    <tr>
      <th>Key</th>
      <th>Action</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td><kbd>←</kbd></td>
      <td>Move left</td>
    </tr>
    <tr>
      <td><kbd>→</kbd></td>
      <td>Move right</td>
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

<h2>Tetromino System</h2>

<p>
  The project implements all seven standard Tetromino types.
  Each piece is represented by its own class derived from the common
  <code>Block</code> abstraction.
</p>

<table>
  <thead>
    <tr>
      <th>Piece</th>
      <th>Implementation</th>
      <th>Rotation States</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>I</td>
      <td><code>IBlock</code></td>
      <td>Defined by the block implementation</td>
    </tr>
    <tr>
      <td>J</td>
      <td><code>JBlock</code></td>
      <td>Defined by the block implementation</td>
    </tr>
    <tr>
      <td>L</td>
      <td><code>LBlock</code></td>
      <td>Defined by the block implementation</td>
    </tr>
    <tr>
      <td>O</td>
      <td><code>OBlock</code></td>
      <td>Defined by the block implementation</td>
    </tr>
    <tr>
      <td>S</td>
      <td><code>SBlock</code></td>
      <td>Defined by the block implementation</td>
    </tr>
    <tr>
      <td>T</td>
      <td><code>TBlock</code></td>
      <td>Defined by the block implementation</td>
    </tr>
    <tr>
      <td>Z</td>
      <td><code>ZBlock</code></td>
      <td>Defined by the block implementation</td>
    </tr>
  </tbody>
</table>

<p>
  The common <code>Block</code> abstraction allows the game state to interact
  with different Tetromino implementations through a consistent interface.
</p>

<hr>

<h2>Game Board</h2>

<p>
  The main game board is represented by a <strong>22 × 10</strong> grid.
  The grid is managed internally using a two-dimensional structure that
  stores the current state of every cell.
</p>

<pre>
Rows:    22
Columns: 10
</pre>

<p>
  The grid is responsible for storing placed blocks and is used during
  movement validation, collision detection, line clearing, and rendering.
</p>

<hr>

<h2>Architecture</h2>

<p>
  The project is organized around several classes with clearly defined
  responsibilities.
</p>

<pre>
                         +----------------+
                         |   MainWindow   |
                         |   WPF / XAML   |
                         +-------+--------+
                                 |
                                 v
                         +----------------+
                         |   GameState    |
                         +-------+--------+
                                 |
               +-----------------+-----------------+
               |                 |                 |
               v                 v                 v
        +-------------+   +-------------+   +-------------+
        |  GameGrid   |   | BlockQueue  |   | Current     |
        |             |   |             |   | Block       |
        +-------------+   +-------------+   +-------------+
                                                   |
                                                   v
                                            +-------------+
                                            |    Block    |
                                            +------+------+
                                                   |
                  +--------+--------+--------+-----+-----+--------+--------+
                  |        |        |        |           |        |        |
                  v        v        v        v           v        v        v
                  I        J        L        O           S        T        Z
</pre>

<hr>

<h2>Core Components</h2>

<h3><code>GameState</code></h3>

<p>
  The <code>GameState</code> class represents the central state of the game.
  It coordinates the current piece, game grid, score, held piece, piece queue,
  movement, rotation, and progression of the game.
</p>

<h3><code>GameGrid</code></h3>

<p>
  Responsible for representing the board and managing the cells occupied by
  previously placed Tetrominoes.
</p>

<h3><code>Block</code></h3>

<p>
  Provides the common abstraction for Tetromino pieces.
  Concrete block classes inherit from this abstraction and define their
  specific shapes and rotation states.
</p>

<h3><code>BlockQueue</code> / <code>GameQueue</code></h3>

<p>
  Responsible for generating and providing upcoming Tetrominoes.
  The implementation uses randomized piece selection while avoiding
  immediately repeating the same block identifier.
</p>

<h3><code>Position</code></h3>

<p>
  Represents coordinates used to position individual block cells inside
  the game grid.
</p>

<h3><code>MainWindow</code></h3>

<p>
  Provides the WPF user interface and connects user input and rendering
  with the underlying game state.
</p>

<hr>

<h2>Game Mechanics</h2>

<h3>Movement</h3>

<p>
  The active Tetromino can move horizontally and vertically.
  Before applying a movement, the target position is validated against
  the board boundaries and occupied cells.
</p>

<h3>Collision Detection</h3>

<p>
  Collision detection prevents the active Tetromino from moving outside
  the playable area or overlapping blocks that have already been placed.
</p>

<p>
  This validation is performed whenever the game attempts to move or rotate
  the active block.
</p>

<h3>Rotation</h3>

<p>
  Each Tetromino contains predefined rotation configurations.
  The game changes the current rotation state and validates the resulting
  positions before applying the rotation.
</p>

<h3>Hard Drop</h3>

<p>
  The hard-drop functionality calculates the maximum valid downward distance
  using the current board state and immediately places the active Tetromino
  at its landing position.
</p>

<h3>Soft Drop</h3>

<p>
  Soft drop allows the player to manually accelerate the downward movement
  of the active Tetromino.
</p>

<h3>Line Clearing</h3>

<p>
  After a block is placed, the game checks the board for completed rows.
  Full rows are removed and the remaining rows are shifted accordingly.
</p>

<h3>Ghost Piece</h3>

<p>
  The ghost piece provides a visual indication of where the active Tetromino
  will land if dropped vertically.
</p>

<p>
  The implementation uses the block drop-distance calculation to determine
  the ghost position.
</p>

<h3>Hold Mechanism</h3>

<p>
  The player can store the current Tetromino using <kbd>C</kbd>.
  A hold-state flag prevents the player from repeatedly swapping pieces
  during the same turn.
</p>

<hr>

<h2>Scoring</h2>

<p>
  The current implementation calculates score based on the number of rows
  cleared.
</p>

<pre>
Score += ClearedRows;
</pre>

<p>
  The scoring system is intentionally simple and provides a foundation for
  implementing more advanced scoring rules in the future.
</p>

<hr>

<h2>Dynamic Difficulty</h2>

<p>
  The falling speed of the active Tetromino increases as the game progresses.
  The current implementation uses configurable delay values.
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
      <td>Maximum Fall Delay</td>
      <td>1000 ms</td>
    </tr>
    <tr>
      <td>Minimum Fall Delay</td>
      <td>75 ms</td>
    </tr>
    <tr>
      <td>Delay Decrease</td>
      <td>25 ms</td>
    </tr>
  </tbody>
</table>

<p>
  This mechanism gradually increases the game speed and difficulty.
</p>

<hr>

<h2>Game Loop</h2>

<p>
  The game uses an asynchronous loop based on timed delays to control
  automatic downward movement.
</p>

<pre>
Initialize Game
      |
      v
Create Game State
      |
      v
Select Active Block
      |
      v
Render Game
      |
      v
Wait for Fall Delay
      |
      v
Attempt Downward Movement
      |
      +------ Success ------> Continue Loop
      |
      +------ Collision
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

<p>
  This design keeps the automatic movement independent from user input
  while allowing keyboard actions to update the game state.
</p>

<hr>

<h2>Rendering</h2>

<p>
  The user interface is implemented using <strong>WPF</strong> and
  <strong>XAML</strong>.
</p>

<p>
  The game board is rendered using a WPF <code>Canvas</code> and an
  <code>Image[,]</code> collection representing the visual cells of the board.
</p>

<p>The rendering system includes:</p>

<ul>
  <li>Game grid rendering</li>
  <li>Active Tetromino rendering</li>
  <li>Ghost piece rendering</li>
  <li>Next piece rendering</li>
  <li>Held piece rendering</li>
  <li>Game state updates</li>
</ul>

<p>
  Rendering is updated as the underlying game state changes.
</p>

<hr>

<h2>Object-Oriented Design</h2>

<table>
  <thead>
    <tr>
      <th>Concept</th>
      <th>Implementation</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>Abstraction</td>
      <td><code>Block</code> provides the common Tetromino abstraction.</td>
    </tr>
    <tr>
      <td>Inheritance</td>
      <td>Individual Tetromino classes inherit from <code>Block</code>.</td>
    </tr>
    <tr>
      <td>Polymorphism</td>
      <td>Different block types provide their own shape and rotation behavior.</td>
    </tr>
    <tr>
      <td>Encapsulation</td>
      <td>Game state and block behavior are maintained inside dedicated classes.</td>
    </tr>
    <tr>
      <td>Separation of Concerns</td>
      <td>Game state, grid management, block logic, and UI rendering have separate responsibilities.</td>
    </tr>
  </tbody>
</table>

<hr>

<h2>Algorithms and Data Structures</h2>

<ul>
  <li>Two-dimensional grid representation</li>
  <li>Coordinate-based block positioning</li>
  <li>Collision detection</li>
  <li>Grid traversal for completed-row detection</li>
  <li>Row removal and downward shifting</li>
  <li>Randomized block generation</li>
  <li>Drop-distance calculation</li>
  <li>State-based game management</li>
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
├── GameState.cs
├── GameGrid.cs
├── BlockQueue.cs
├── Position.cs
├── Context.cs
├── Service.cs
├── savedata.cs
│
├── MainWindow.xaml
├── MainWindow.xaml.cs
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
      <th>Role</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>C#</td>
      <td>Game and application logic</td>
    </tr>
    <tr>
      <td>.NET 6</td>
      <td>Application framework and runtime</td>
    </tr>
    <tr>
      <td>WPF</td>
      <td>Desktop user interface</td>
    </tr>
    <tr>
      <td>XAML</td>
      <td>UI definition</td>
    </tr>
    <tr>
      <td>Entity Framework Core</td>
      <td>Database-related infrastructure</td>
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
  <li>Windows</li>
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
  The project can also be opened directly in Visual Studio and launched
  using the standard WPF debugging configuration.
</p>

<hr>

<h2>Gameplay Flow</h2>

<ol>
  <li>Initialize the game board and block queue.</li>
  <li>Create or select the active Tetromino.</li>
  <li>Render the current game state.</li>
  <li>Automatically move the active piece downward.</li>
  <li>Process player input for movement and rotation.</li>
  <li>Allow hold, soft drop, or hard drop actions.</li>
  <li>Lock the Tetromino when downward movement is no longer possible.</li>
  <li>Detect and clear completed rows.</li>
  <li>Update the score.</li>
  <li>Spawn the next Tetromino.</li>
  <li>Check for game-over conditions.</li>
  <li>Continue the game loop.</li>
</ol>

<hr>

<h2>Database Integration</h2>

<p>
  The repository contains database-related infrastructure based on
  <strong>Entity Framework Core</strong> and SQL Server / LocalDB.
</p>

<p>
  Database-related components exist in the project, but persistent score
  storage should be considered an area for further refinement rather than
  a fully polished production feature.
</p>

<hr>

<h2>Current Limitations</h2>

<ul>
  <li>The scoring system is currently based on the number of cleared rows.</li>
  <li>A complete standard wall-kick rotation system can be added.</li>
  <li>The block generator can be improved with standard seven-bag randomization.</li>
  <li>Automated unit and integration testing can be expanded.</li>
  <li>Persistent high-score management can be further developed.</li>
  <li>The database layer can be cleaned up and integrated more consistently.</li>
  <li>The user interface can be improved with additional animations and visual feedback.</li>
</ul>

<hr>

<h2>Future Improvements</h2>

<table>
  <thead>
    <tr>
      <th>Area</th>
      <th>Improvement</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>Scoring</td>
      <td>Implement standard Tetris scoring, combos, and level-based multipliers.</td>
    </tr>
    <tr>
      <td>Rotation</td>
      <td>Implement a complete wall-kick system.</td>
    </tr>
    <tr>
      <td>Randomization</td>
      <td>Implement seven-bag Tetromino randomization.</td>
    </tr>
    <tr>
      <td>Persistence</td>
      <td>Implement reliable high-score and player-statistics storage.</td>
    </tr>
    <tr>
      <td>Testing</td>
      <td>Add automated unit and integration tests for core game mechanics.</td>
    </tr>
    <tr>
      <td>UI</td>
      <td>Add improved animations, transitions, and gameplay feedback.</td>
    </tr>
    <tr>
      <td>Audio</td>
      <td>Add sound effects and background music.</td>
    </tr>
    <tr>
      <td>Architecture</td>
      <td>Further separate game logic from presentation and infrastructure concerns.</td>
    </tr>
  </tbody>
</table>

<hr>

<h2>Testing Strategy</h2>

<p>
  The core gameplay can be validated through manual gameplay testing,
  while the game logic can be further covered using automated unit tests.
</p>

<h3>Important Test Cases</h3>

<ul>
  <li>Horizontal movement at board boundaries</li>
  <li>Collision with existing blocks</li>
  <li>Collision with the bottom of the board</li>
  <li>Clockwise rotation</li>
  <li>Counter-clockwise rotation</li>
  <li>Hard-drop positioning</li>
  <li>Ghost-piece calculation</li>
  <li>Hold-piece restrictions</li>
  <li>Single-line clearing</li>
  <li>Multiple-line clearing</li>
  <li>Game-over detection</li>
  <li>Increasing fall speed</li>
</ul>

<hr>

<h2>Software Engineering Concepts</h2>

<table>
  <thead>
    <tr>
      <th>Concept</th>
      <th>Demonstrated Through</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>Object-Oriented Programming</td>
      <td>Game entities represented as dedicated classes.</td>
    </tr>
    <tr>
      <td>Inheritance</td>
      <td>Concrete Tetromino classes derived from <code>Block</code>.</td>
    </tr>
    <tr>
      <td>Polymorphism</td>
      <td>Common block behavior with specialized Tetromino implementations.</td>
    </tr>
    <tr>
      <td>Encapsulation</td>
      <td>Game state and mechanics managed inside dedicated components.</td>
    </tr>
    <tr>
      <td>Data Structures</td>
      <td>Two-dimensional grid and piece queue.</td>
    </tr>
    <tr>
      <td>Algorithms</td>
      <td>Collision detection, row clearing, and drop-distance calculation.</td>
    </tr>
    <tr>
      <td>Asynchronous Programming</td>
      <td>Timed game loop implemented using asynchronous delays.</td>
    </tr>
    <tr>
      <td>UI Development</td>
      <td>WPF and XAML-based desktop interface.</td>
    </tr>
  </tbody>
</table>

<hr>

<h2>Learning Outcomes</h2>

<p>
  Through this project, practical experience was gained in:
</p>

<ul>
  <li>C# application development</li>
  <li>.NET desktop development</li>
  <li>WPF and XAML</li>
  <li>Object-oriented software design</li>
  <li>Game-state management</li>
  <li>Grid-based algorithms</li>
  <li>Collision detection</li>
  <li>Data structure implementation</li>
  <li>Asynchronous programming</li>
  <li>Software architecture</li>
  <li>Version control with Git and GitHub</li>
</ul>

<hr>

<h2>Academic Context</h2>

<p>
  This project was developed as a practical application of programming,
  object-oriented design, algorithms, data structures, and software engineering
  concepts.
</p>

<p>
  Rather than implementing the game as a single monolithic program, the project
  separates the main responsibilities into reusable components such as
  <code>GameState</code>, <code>GameGrid</code>, <code>BlockQueue</code>,
  <code>Block</code>, and the individual Tetromino implementations.
</p>

<hr>

<h2>Repository</h2>

<div align="center">

<p>
  <a href="https://github.com/MOHAMMAD-KIMIA/Tetris-Project">
    <img src="https://img.shields.io/badge/Source%20Code-GitHub-181717?style=for-the-badge&logo=github" alt="GitHub">
  </a>
</p>

<p>
  <a href="https://github.com/MOHAMMAD-KIMIA/Tetris-Project">
    github.com/MOHAMMAD-KIMIA/Tetris-Project
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
  Software Development &amp; Artificial Intelligence
</p>

<p>
  <a href="https://github.com/MOHAMMAD-KIMIA">
    GitHub Profile
  </a>
</p>

</div>

// Following is an ex of enum in typescript based on gaming sceanrio
enum GameState {
  Starting,
  Playing,
  Paused,
  GameOver
};


// Enum is a way to define a set of named constants. In this example,
// we have defined an enum called GameState with four possible values: Starting, Playing, Paused, and GameOver.

// By default, the first value (Starting) is assigned the numeric value 0, and each subsequent value is incremented by 1.
// So, Playing will be 1, Paused will be 2, and GameOver will be 3.

let currentState: GameState = GameState.Starting;
console.log("Current game state: " + GameState[currentState]); // Output: Current game state: Starting
currentState = GameState.Playing;
console.log("Current game state: " + GameState[currentState]);
currentState = GameState.Paused;
console.log("Current game state: " + GameState[currentState]);
currentState = GameState.GameOver;
console.log("Current game state: " + GameState[currentState]);

// Application of Enum in in general is:
// 1) To represent a fixed set of related constants, such as days of the week, months of the year, or states in a game.
// 2) To improve code readability and maintainability by giving meaningful names to constant values.
// 3) To enable type safety by restricting the values that a variable can take to a predefined set of options.
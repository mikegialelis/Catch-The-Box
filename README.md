# Catch the Box – C# Windows Forms Game

A simple **Ckick the Moving Target** desktop game built using **C#** and **Windows Forms** in **Visual Studio**.

The project includes **two forms**:
- Form1 - Game Play
- Form2 - Setup/Main Menu

---

## Game Overview

Catch the Box is a fast-paced game where the player tries to click on a moving box as many times as possible within 60 seconds.

The game tracks:

- Player score
- Highscore
- Countdown timer
- Level mode (optional penalty for misclicks in Level 2)


---

## Game Modes

### Setup Form

- Enter your **username**.
- Select a **level**:
  - Level 1 → Normal mode
  - Level 2 → Clicking outside the box decreases score
- Press **Start** to open the game.

### Game Form

- **Click the box** to increase your score.
- The box moves **randomly** across the panel every timer tick.
- The game lasts **60 seconds**, after which:
   - Score ≥ 40 → **You win!**
   - Score < 40 → **Game over**
- Players can **restart** the game using the Restart button.
- Level 2 adds a **penalty** for clicking outside the box.

---

## Game Logic

- The box is implemented using **PictureBox**.
- **Random positions** generated using the Random class.
- **Two timers** control:
   - Box movement (timer1)
   - Countdown (timer2)
- Labels display:
  - **Score**
  - **Highscore**
  - **Time left**
  - **Username greeting**

---

## User Interface

The application uses **Windows Forms** and includes:

- **PictureBox** – target to click
- **Buttons** – Start / Restart
- **Labels** – Score, Highscore, Timer, Username
- **Radio Buttons** – Level selection (Level 1 / Level 2)
- **TextBox** – Enter username
- **Panel** – Game area

---

## Technologies Used

- C#
- .NET Framework
- Windows Forms
- Visual Studio

---

## How to Run

1. Clone the repository

```bash
git clone https://github.com/mikegialelis/Catch-The-Box.git
```
2. Open the project in Visual Studio
3. Run the project with F5

﻿using System.Collections.Generic;
using Stockfish.NET.Models;

namespace Stockfish.NET
{
    public interface IStockfish
    {
        int Depth { get; set; }
        int SkillLevel { get; set; }
        void SetPosition(params string[] move);
        string GetBoardVisual();
        string GetFenPosition();
        void SetFenPosition(string fenPosition, params string[] moves);
        string GetBestMove();
        string GetBestMoveTime(int time = 1000);
        bool IsMoveCorrect(string moveValue);
        Evaluation GetEvaluation();
    }
}
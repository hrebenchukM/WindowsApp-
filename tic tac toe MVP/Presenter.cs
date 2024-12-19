using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe_MVP
{
    public class Presenter
    {
        private readonly Model _model;
        private readonly IView _view;

        public Presenter(Model model, IView view)
        {
            _model = model;
            _view = view;

            // Презентер подписывается на уведомления о событиях Представления
            _view.ClickEvent += ClickEvent;
            _view.StartGameEvent += StartGameEvent;
            _view.EasyEvent += EasyEvent;
            _view.HardEvent += HardEvent;
            _view.PlayerFirstEvent += PlayerFirstEvent;
            _view.ComputerFirstEvent += ComputerFirstEvent;
        }

        private void ClickEvent(object sender, int index)
        {
            if (_model.MakeMove(index))
            {
                _view.UpdateBoard(_model.gameBoard);
                if (_model.CheckGameState())
                {
                    string message = _model.CheckWin() ? "Человек X выиграл!" : "Ничья!";
                    _view.DisplayMessage(message);
                    _model.GameStarted = false;
                }
                else
                {
                    _model.ComputerMove();
                    _view.UpdateBoard(_model.gameBoard);
                    if (_model.CheckGameState())
                    {
                        string message = _model.CheckWin() ? "Компьютер O выиграл!" : "Ничья!";
                        _view.DisplayMessage(message);
                        _model.GameStarted = false;
                    }
                }
            }
        }

        private void StartGameEvent(object sender, EventArgs e)
        {
            _model.Reset();
            _view.UpdateBoard(_model.gameBoard);
            _model.PlayerX = _model.FirstPlayerX;
            _model.GameStarted = true;

            if (!_model.PlayerX)
            {
                _model.ComputerMove();
                _view.UpdateBoard(_model.gameBoard);
            }
        }

        private void EasyEvent(object sender, EventArgs e)
        {
            _model.Easy = true;
            _view.DisplayMessage("Уровень сложности: Легкий");
        }

        private void HardEvent(object sender, EventArgs e)
        {
            _model.Easy = false;
            _view.DisplayMessage("Уровень сложности: Сложный");
        }

        private void PlayerFirstEvent(object sender, EventArgs e)
        {
            _model.FirstPlayerX = true;
            _view.DisplayMessage("Первый ход: Игрок");
        }

        private void ComputerFirstEvent(object sender, EventArgs e)
        {
            _model.FirstPlayerX = false;
            _view.DisplayMessage("Первый ход: Компьютер");
        }
    }
}

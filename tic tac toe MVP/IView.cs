using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe_MVP
{
    public interface IView
    {
        event EventHandler<int> ClickEvent;
        event EventHandler StartGameEvent;
        event EventHandler EasyEvent;
        event EventHandler HardEvent;
        event EventHandler PlayerFirstEvent;
        event EventHandler ComputerFirstEvent;

        void UpdateBoard(List<int> gameBoard);
        void DisplayMessage(string message);
    }

}

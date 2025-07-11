using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIVPROJ.dev
{
    public partial class BuildMenu : Node2D
    {
        public override void _Ready()
        {
            GD.Print("Build Menu is ready.");
        }
        public override void _Input(InputEvent @event)
        {
            if (@event.IsActionPressed("AccessBuildMenu"))
            {
                if (Visible)
                {
                    Close();
                }
                else
                {
                    Open();
                }
            }
        }

        public void Open()
        {
            this.Visible = true;
            GD.Print("Build Menu opened.");
        }

        public void Close()
        {
            this.Visible = false;
            GD.Print("Build Menu closed.");
        }
    }
}

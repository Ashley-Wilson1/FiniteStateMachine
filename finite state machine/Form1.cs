using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finite_state_machine
{
    public partial class Form1 : Form
    {
        FSM fsm;
        List<State> states = new List<State>();
        List<Transition> transitions = new List<Transition>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }
        
        private void btn_draw_Click(object sender, EventArgs e)
        {
           
            Graphics graphics = this.CreateGraphics();
            
            Pen p = new Pen(Color.Black, 8);

            if (fsm != null)
            {
                foreach (State s in fsm.GetStates())
                {
                    s.drawState(graphics);
                    this.Controls.Add(s.getLabel());
                }
                foreach (Transition t in fsm.GetTransitions())
                {
                    t.drawTransition(graphics);
                    this.Controls.Add(t.getLabel());
                }
            }

        }

        private void btn_check_Click(object sender, EventArgs e)
        {

            string input = txt_enter.Text;
            char[] inputChars = input.ToCharArray();
            State end = fsm.getAcceptingState();
            State current = fsm.getInitialState();

            accepting.Size = new Size(200, 20);
            accepting.Location = new Point(400,20);

            if (fsm.check(current,inputChars)==end)
            {
                accepting.Text = "Accepted";
                accepting.ForeColor = Color.Green;
            }
            else
            {
                accepting.Text = "Not Accepted";
                accepting.ForeColor = Color.Red;
            }
            
        }

        int c=0;
        int d = 0;
        private void Btn_newFsm_Click(object sender, EventArgs e)
        {
            
            fsm = new FSM(txt_fsmName.Text);
            states.Clear();
            transitions.Clear();
            c = 0;
            d = 0;
        }

        private void Btn_addState_Click(object sender, EventArgs e)
        {
            states.Add(new State(txt_stateName.Text, int.Parse(txt_stateX.Text), int.Parse(txt_stateY.Text), cb_end.Checked));
            fsm.AddState(states[c]);
            if (cb_end.Checked)
            {
                fsm.setAcceptingState(states[c]);
            }
            if (c == 0)
            {
                fsm.setInitialState(states[c]);
            }
            c++;
        }

        private void Btn_addTransition_Click(object sender, EventArgs e)
        {
            transitions.Add(new Transition(char.Parse(txt_transitionVal.Text)));

            int i = 0;
            foreach(State s in states )
            {
                if (txt_transitionVal.Text == "1")
                {
                    if (states[i].getName().Equals(txt_positionState.Text))
                    {
                        states[i].setTransition1(transitions[d]);
                        transitions[d].setPosition(states[i]);
                    }
                    if (states[i].getName().Equals(txt_pointedState.Text))
                    {
                        states[i].setTransition1(transitions[d]);
                        transitions[d].setPointed(states[i]);
                    }
                }
                if (txt_transitionVal.Text == "0")
                {
                    if (states[i].getName().Equals(txt_positionState.Text))
                    {
                        states[i].setTransition0(transitions[d]);
                        transitions[d].setPosition(states[i]);
                    }
                    if (states[i].getName().Equals(txt_pointedState.Text))
                    {
                        states[i].setTransition0(transitions[d]);
                        transitions[d].setPointed(states[i]);
                    }
                }
                i++;
            }
            fsm.AddTransition(transitions[d]);
            d++;
        }

        private void btn_PreMadeFsm_Click(object sender, EventArgs e)
        {
            State s1 = new State("S1", 100, 100, false);
            State s2 = new State("S2", 400, 100, false);
            State s3 = new State("S3", 700, 400, true);
            State s4 = new State("S4", 100, 400, false);

            Transition s1Tos2 = new Transition(s1, s2, '0');
            Transition s1Tos4 = new Transition(s1, s4, '1');
            Transition s2Tos1 = new Transition(s2, s1, '0');
            Transition s2Tos3 = new Transition(s2, s3, '1');
            Transition s3Tos2 = new Transition(s3, s2, '0');
            Transition s3Tos3 = new Transition(s3, s3, '1');
            Transition s4Tos4 = new Transition(s4, s4, '0');
            Transition s4Tos4_2 = new Transition(s4, s4, '1');

            s1.setTransition0(s1Tos2);
            s1.setTransition1(s1Tos4);
            s2.setTransition0(s2Tos1);
            s2.setTransition1(s2Tos3);
            s3.setTransition0(s3Tos2);
            s3.setTransition1(s3Tos3);
            s4.setTransition0(s4Tos4);
            s4.setTransition1(s4Tos4_2);

            fsm = new FSM("fsm");

            fsm.AddState(s1);
            fsm.AddState(s2);
            fsm.AddState(s3);
            fsm.AddState(s4);
            fsm.setInitialState(s1);
            fsm.setAcceptingState(s3);

            fsm.AddTransition(s1Tos2);
            fsm.AddTransition(s1Tos4);
            fsm.AddTransition(s2Tos1);
            fsm.AddTransition(s2Tos3);
            fsm.AddTransition(s3Tos2);
            fsm.AddTransition(s3Tos3);
            fsm.AddTransition(s4Tos4);
            fsm.AddTransition(s4Tos4_2);
        }
    }

    public class FSM
    {
        List<State> states;
        List<Transition> transitions;
        State acceptingState;
        State initialState;
        string name;
        public FSM(string name)
        {
            this.name = name;
            states = new List<State>();
            transitions = new List<Transition>();

        }

        public void AddState(State s)
        {
            states.Add(s);
        }

        public void AddTransition(Transition t)
        {
            transitions.Add(t);
        }

        public List<State> GetStates()
        {
            return states;
        }

        public List<Transition> GetTransitions()
        {
            return transitions;
        }

        public void setAcceptingState(State acceptingState)
        {
            this.acceptingState = acceptingState;
        }

        public State getAcceptingState()
        {
            return acceptingState;
        }

        public State getInitialState()
        {
            return initialState;
        }

        public void setInitialState(State initialState)
        {
            this.initialState = initialState;
        }
        public State check(State current, char[] input)
        {
            Transition t;
            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] == '1')
                {
                    t = current.getTransition1();
                    current = t.getNewState();
                }
                else
                {
                    t = current.getTransition0();
                    current = t.getNewState();

                }
            }
            return current;
        }
    }

    public class State 
    {
        
        string name;
        Transition transition0;
        Transition transition1;
        int x=100;
        int y=100;
        Rectangle rectangle;
        bool end;
        

        public State(string name, Transition transition0,Transition transition1, int x, int y, bool end)
        {
            this.name = name;
            this.transition0 = transition0;
            this.transition1 = transition1;
            this.x = x;
            this.y = y;
            this.end = end;
        }

        public State(string name, int x, int y, bool end)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.end = end;
        }

        public State(string name)
        {
            this.name = name;
        }

        public void setEndBool(bool b)
        {
            this.end = b;
        }

        public void setPoint(Point p)
        {
            this.x = p.X;
            this.y = p.Y;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public void setTransition0(Transition t)
        {
            this.transition0 = t;
        }

        public void setTransition1(Transition t)
        {
            this.transition1 = t;
        }

        public Label getLabel()
        {
            Label label = new Label();
            label.Text = name;
            label.Font =  new Font(label.Font, FontStyle.Bold);
            label.Size = new Size(30, 20);
            label.Location = new Point(x + 40, y + 45);
            return label;
        }

        public void drawState(Graphics graphics)
        {
            this.rectangle = new Rectangle(x, y, 100, 100);
            Pen p = new Pen(Color.Black, 3);
            graphics.DrawEllipse(p, rectangle);
            if (end)
            {
                graphics.DrawEllipse(p, x+5, y+5, 90,90);
            }
            
           
        }

        public Point getPoint()
        {
            Point point = new Point(x, y);
            return point;
        }

        public Transition getTransition0()
        {
            return transition0;
        }

        public Transition getTransition1()
        {
            return transition1;
        }

        public string getName()
        {
            return name;
        }
    }

    public class Transition
    {
        State position;
        State pointed;
        Point mid;
        char value;

        public Transition(State position,State pointed,char value)
        {
            this.position = position;
            this.pointed = pointed;
            this.value = value;
        }

        public Transition(char value)
        {
            this.value = value;
        }

        public void setValue(char input)
        {
            this.value = input;
        }

        public void setPosition(State positioned)
        {
            this.position = positioned;
        }

        public void setPointed(State pointed)
        {
            this.pointed = pointed;
        }

        public void drawTransition(Graphics graphics)
        {
            Pen p = new Pen(Color.Black, 8);
            
            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            Point point1;
            Point point3;
            Point point2;
            int point2X;
            int point2Y;

            if (position.getPoint().X == pointed.getPoint().X)
            {
                if(position.getPoint().Y < pointed.getPoint().Y)
                {
                    point1 = new Point(position.getPoint().X + 80, position.getPoint().Y+100);
                    point3 = new Point(pointed.getPoint().X + 80, pointed.getPoint().Y);
                    point2X = ((point1.X + point3.X) / 2) + 30;
                    point2Y = ((point1.Y + point3.Y) / 2);
                    point2 = new Point(point2X, point2Y);
                    this.mid = new Point(point2X+30, point2Y);
                }
                else if(position.getPoint().Y > pointed.getPoint().Y)
                {
                    point1 = new Point(position.getPoint().X+20, position.getPoint().Y );
                    point3 = new Point(pointed.getPoint().X+20, pointed.getPoint().Y+100);
                    point2X = ((point1.X + point3.X) / 2) -30;
                    point2Y = ((point1.Y + point3.Y) / 2);
                    point2 = new Point(point2X, point2Y);
                    this.mid = new Point(point2X-30, point2Y );
                }
                else
                {
                    if (value == '1')
                    {
                        point1 = new Point(position.getPoint().X + 100, position.getPoint().Y + 100);
                        point3 = new Point(position.getPoint().X + 70, position.getPoint().Y + 100);
                        point2X = ((point1.X + point3.X) / 2);
                        point2Y = ((point1.Y + point3.Y) / 2)+30;
                        point2 = new Point(point2X, point2Y);
                        this.mid = new Point(point2X , point2Y+30);
                    }
                    else
                    {
                        point1 = new Point(position.getPoint().X , position.getPoint().Y + 100);
                        point3 = new Point(position.getPoint().X +30, position.getPoint().Y + 100);
                        point2X = ((point1.X + point3.X) / 2);
                        point2Y = ((point1.Y + point3.Y) / 2) + 30;
                        point2 = new Point(point2X, point2Y);
                        this.mid = new Point(point2X, point2Y + 30);
                    }
                } 
               
                
                
            }
            else if(position.getPoint().Y == pointed.getPoint().Y)
            {
                if(position.getPoint().X < pointed.getPoint().X)
                {
                    point1 = new Point(position.getPoint().X + 100, position.getPoint().Y+20);
                    point3 = new Point(pointed.getPoint().X , pointed.getPoint().Y+20);
                    point2X = ((point1.X + point3.X) / 2);
                    point2Y = ((point1.Y + point3.Y) / 2)-30;
                    point2 = new Point(point2X, point2Y);
                    this.mid = new Point(point2X, point2Y - 30);
                }
                else if(position.getPoint().X > pointed.getPoint().X)
                {
                    point1 = new Point(position.getPoint().X, position.getPoint().Y+80);
                    point3 = new Point(pointed.getPoint().X+100, pointed.getPoint().Y+80);
                    point2X = ((point1.X + point3.X) / 2) ;
                    point2Y = ((point1.Y + point3.Y) / 2)+30;
                    point2 = new Point(point2X, point2Y);
                    this.mid = new Point(point2X, point2Y + 30);
                }
                else
                {
                    if (value == '1')
                    {
                        point1 = new Point(position.getPoint().X + 100, position.getPoint().Y + 100);
                        point3 = new Point(position.getPoint().X + 70, position.getPoint().Y + 100);
                        point2X = ((point1.X + point3.X) / 2);
                        point2Y = ((point1.Y + point3.Y) / 2) + 30;
                        point2 = new Point(point2X, point2Y);
                        this.mid = new Point(point2X, point2Y + 30);
                    }
                    else
                    {
                        point1 = new Point(position.getPoint().X, position.getPoint().Y + 100);
                        point3 = new Point(position.getPoint().X + 30, position.getPoint().Y + 100);
                        point2X = ((point1.X + point3.X) / 2);
                        point2Y = ((point1.Y + point3.Y) / 2) + 30;
                        point2 = new Point(point2X, point2Y);
                        this.mid = new Point(point2X, point2Y + 30);
                    }
                }
                
            }
            else
            {
                if(position.getPoint().X < pointed.getPoint().X)
                {
                    if(position.getPoint().Y < pointed.getPoint().Y)
                    {
                        point1 = new Point(position.getPoint().X + 110, position.getPoint().Y+90 );
                        point3 = new Point(pointed.getPoint().X+10 , pointed.getPoint().Y-10);
                        point2X = ((point1.X + point3.X) / 2) + 30;
                        point2Y = ((point1.Y + point3.Y) / 2);
                        point2 = new Point(point2X, point2Y);
                        this.mid = new Point(point2X+30, point2Y - 30);
                    }
                    else
                    {
                        point1 = new Point(position.getPoint().X + 90, position.getPoint().Y - 10);
                        point3 = new Point(pointed.getPoint().X, pointed.getPoint().Y+100 );
                        point2X = ((point1.X + point3.X) / 2) - 30;
                        point2Y = ((point1.Y + point3.Y) / 2);
                        point2 = new Point(point2X, point2Y);
                        this.mid = new Point(point2X-30, point2Y + 30);
                    }
                }
                else
                {
                    if (position.getPoint().Y < pointed.getPoint().Y)
                    {
                        point1 = new Point(position.getPoint().X+20, position.getPoint().Y+110);
                        point3 = new Point(pointed.getPoint().X+100, pointed.getPoint().Y );
                        point2X = ((point1.X + point3.X) / 2) + 30;
                        point2Y = ((point1.Y + point3.Y) / 2);
                        point2 = new Point(point2X, point2Y);
                        this.mid = new Point(point2X-30, point2Y + 30);
                    }
                    else
                    {
                        point1 = new Point(position.getPoint().X-10, position.getPoint().Y +10);
                        point3 = new Point(pointed.getPoint().X+90, pointed.getPoint().Y+90);
                        point2X = ((point1.X + point3.X) / 2) - 30;
                        point2Y = ((point1.Y + point3.Y) / 2);
                        point2 = new Point(point2X, point2Y);
                        this.mid = new Point(point2X-30, point2Y + 30);
                    }
                }
                
            }


            
            Point[] points = new Point[3] { point1, point2, point3 };
            graphics.DrawCurve(p, points);
        }

        public State getNewState()
        {
            return pointed;
        }

        public Label getLabel()
        {
            Label label = new Label();
            label.Text = value.ToString();
            label.Font = new Font(label.Font, FontStyle.Bold);
            label.Size = new Size(20, 20);
            label.Location = mid;
            return label;
        }

        public State getCurrentState()
        {
            return position;
        }
        public char getValue()
        {
            return value;
        }
    }
}

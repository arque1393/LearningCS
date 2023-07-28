namespace ConsoleManager.brightSpace
{
    public class Blend
    { 
        public int a;
        public int b { get; set; } = 45;
        public int A { get { return a; } set { if (value > 0) a = value; } }
        public Blend(int a,int b){this.a = a;this.b = b;}
        public Blend(int a){this.a=a;}
        public Blend(){}
        public void disp(){
            Console.WriteLine($"Blend Object : a = {this.a}");
            Console.WriteLine($"Blend Object : b = {this.b}");
        }
        internal void Blue(){Console.WriteLine("internal Blue ");}
        
    }
}
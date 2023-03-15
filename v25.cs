 namespace v25
 {

    class Kalkulator
    {

        private string opr;
        public Kalkulator(string op){
            opr = op;
        }

        public void kali(){
            Console.WriteLine($"perkalian {opr}");
        }
    }
 }
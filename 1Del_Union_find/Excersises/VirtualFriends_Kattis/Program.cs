using Kattis.IO;

namespace ConsoleApp1{

    class Program{

        public static void Main(String[] args){

            Scanner scanner             = new Scanner();
            BufferedStdoutWriter writer = new BufferedStdoutWriter();

            int N = scanner.NextInt();
            int F = scanner.NextInt();

            string n1 = scanner.Next();

            
            writer.Write(N + " " + F + " " + n1);

            writer.Close();

            VirtualFriendUnionFind vfuf = new VirtualFriendUnionFind();
            Console.WriteLine(vfuf.union("Fred","Barney"));
            Console.WriteLine(vfuf.union("Barney","Betty"));
            Console.WriteLine(vfuf.union("Betty","Wilma"));
            vfuf.printDictonary();
            Console.WriteLine(vfuf.count);
        }
    }


    class VirtualFriendUnionFind{
            Dictionary<string, string>  dictonary   = new Dictionary<string, string>();
            Dictionary<string,int>      sizes       = new Dictionary<string, int>();
            public int count;

            public int union(string a, string b){
                int groupSize = 0;

                if(!dictonary.ContainsKey(a))   {   dictonary.Add(a,a); count++; sizes.Add(a,1);}
                if(!dictonary.ContainsKey(b))   {   dictonary.Add(b,b); count++; sizes.Add(b,1);}

                string rootA = find(a);
                string rootB = find(b);

                if(sizes[rootA] < sizes[rootB]) { dictonary[rootA] = rootB;   sizes[rootB] += sizes[rootA]; groupSize = sizes[rootB];}
                else                            { dictonary[rootB] = rootA;   sizes[rootA] += sizes[rootB]; groupSize = sizes[rootA];}
                
                count--;

                return groupSize;
            }


            public string find(string a){
                while(a != dictonary[a]){ a = dictonary[a]; }
                return a; 
            }

            public void printDictonary(){
                Console.WriteLine("-------------------------");
                foreach(var i in dictonary){
                    Console.WriteLine(i.Key + " " + i.Value);
                }
                foreach(var i in sizes){
                    Console.WriteLine(i.Key + " " + i.Value);
                }
                Console.WriteLine("-------------------------");

            }


    }


}
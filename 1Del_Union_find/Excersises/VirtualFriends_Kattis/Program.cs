using Kattis.IO;
using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1{

    class Program{

        public static void Main(String[] args){

            Scanner scanner             = new Scanner();
            BufferedStdoutWriter writer = new BufferedStdoutWriter();

            Dictionary<string,int> map  = new Dictionary<string, int>();

            int N = scanner.NextInt();

            for(int i = 0 ; i < N ; i++){
                
                int F = scanner.NextInt();
                map.Clear();
                VirtualFriendUnionFind vfuf = new VirtualFriendUnionFind(F*2);

                for(int k = 0 ; k < F ; k++){

                    string n1 = scanner.Next();
                    string n2 = scanner.Next();

                    if(!map.ContainsKey(n1)){map[n1] = map.Count();}
                    if(!map.ContainsKey(n2)){map[n2] = map.Count();}

                    //vfuf.printAll();

                    writer.WriteLine(vfuf.union(map[n1],map[n2]));    
                }
            
            }

            writer.Close();
        }
    }


    class VirtualFriendUnionFind{
            public int[] ids;
            public int[] sizes;
            public int count;

            public VirtualFriendUnionFind(int N){ 
                ids     = new int[N];
                sizes   = new int[N];
                for(int i = 0 ; i < N ; i++){
                    ids[i] = i;
                    sizes[i] = 1;
                }
            }

            public int union(int a, int b){
                int groupSize = 0;

                int rootA = find(a);
                int rootB = find(b);

                if(rootA == rootB) return sizes[rootA];

                if(sizes[rootA] < sizes[rootB]) { ids[rootA] = rootB;   sizes[rootB] += sizes[rootA]; groupSize = sizes[rootB];}
                else                            { ids[rootB] = rootA;   sizes[rootA] += sizes[rootB]; groupSize = sizes[rootA];}
                
                count--;

                return groupSize;
            }


            public int find(int a){
                while(a != ids[a]){ a = ids[a]; }
                return a; 
            }

            public void printAll(){
                Console.WriteLine("------------------------");
                    for(int i = 0 ; i < 5 ; i++){
                        Console.WriteLine(ids[i]);
                    }
                Console.WriteLine("------------------------");
            }
    
    }

}
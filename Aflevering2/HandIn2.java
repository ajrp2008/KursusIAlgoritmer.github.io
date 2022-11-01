public class HandIn2{

  public static void main(String[] args){
      In in         = new In(args[0]);
      int V         = in.readInt();
      //Graf og knuder
      Digraph G     = new Digraph(V+4);
      //Kanter
      for(int i=1 ; i<V ; i++){G.addEdge(in.readInt(),i);}
      for(int i=V+1; i<V+4; i++){G.addEdge(i-1,i);}
      G.addEdge(V+3,0);
      for(int i=0 ; i<G.V() ; i++){
        if(((Bag<Integer>)G.adj(i)).isEmpty()){G.addEdge(i,V);}
      }
      //Forespørgsler
      int q         = in.readInt();
      for(int i=0; i<q ; i++){
        String s = in.readString();
        if(s.equals("vej")) printPath(G,in.readInt(),in.readInt());
        if(s.equals("tid")) printTime(G,in.readInt(),in.readInt());
      }
    }

    public static void printTime(Digraph G, int from,int to){
      BreadthFirstDirectedPaths bfdp =new BreadthFirstDirectedPaths(G,from);
      StdOut.println(bfdp.distTo(to));

    }

    public static void printPath(Digraph G, int from,int to){
      BreadthFirstDirectedPaths bfdp =new BreadthFirstDirectedPaths(G,from);
      Stack<Integer> path = (Stack<Integer>)bfdp.pathTo(to);
      int n = path.size();
      for(int i=0; i<n-1; i++){
        int e = path.pop();
        if(e<G.V()-4)StdOut.print(e+ "->");
      }
      StdOut.println(path.pop());
    }
}

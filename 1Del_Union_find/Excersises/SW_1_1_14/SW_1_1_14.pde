

void setup(){
  println(lg(16));
  println(log(16) / log(2));
}

// EKSEMPEL
// 2^3     = 8 
// log2(8) = 3 
// 2*2*2   = 8
// 
// Dvs. log2(8) svarer til hvor mange gange skal man halvvere 8 for at få 1 ??
// 8/2 = 4 .. 4/2 = 2 ... 2/2 = 1 .... 

int lg(int n){
 int r = 0;
 while(n != 1 && n>0){
   r++;
   n/=2;
 }
 return r;
  
}

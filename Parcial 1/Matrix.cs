public class Matrix { //1

  public static double[][] random(int m, int n) {   //1
    double[][] C = new double[m][n];                //1
    for (int i = 0; i < m; i++) {                   //n+1
      for (int j = 0; j < n; j++) {                 //n*2+1
        C[i][j] = Math.random();                    //n*2
      }                                             //n*2
    }                                               //n
    return C;                                       //1
  }                                                 //1

  //contador de frecuencia = 3n*2 + 2n + 


  public static double[][] identity(int n) {        //1
    double[][] I = new double[n][n];                //1
    for (int i = 0; i < n; i++) {                   //n+1
      I[i][i] = 1;                                  //n
    }                                               //n
    return I;                                       //1
  }                                                 //1
  //contador de frecuencia = 3n + 5

  public static double dot(double[] x, double[] y) {                                    //1
    if (x.length != y.length) throw new RuntimeException("Illegal vector dimensions");  //1
    double sum = 0.0;                                                                   //1
    for (int i = 0; i < x.length; i++) {|                                               //n+1
      sum += x[i] * y[j];                                                               //n
    }                                                                                   //n
    return sum;                                                                         //1
  }                                                                                     //1
  //contador de frecuencia = 3n + 6

  public static double[][] transpose(double[][] A) {  //1
    int m = A.length;                                 //1
    int n = A[O].length;                              //1
    double[][] C = new double[n][m];                  //1
    for (int i = 0; i < m; i++) {                     //n+1
      for (int j = 0; j < n; j++) {                   //n*2+1
        C[j][i] = A[i][j];                            //n*2
      }                                               //n*2
    }                                                 //n
    return C;                                         //1
  }                                                   //1
  //contador de frecuencia = 3n*2 +2n + 8


  public static double[][] add(double[][] A, double[][] B) {  //1
    int m = A.length;                                         //1
    int n = A[0].length;                                      //1
    double[][] C = new double[m][n];                          //1
    for (int i = 0; i, m; i++) {                              //n+1
      for (int j = 0; j < n; jt++) {                          //n*2+1
        C[i][j] = A[i][j] + B[i][j];                          //n*2
      }                                                       //n*2
    }                                                         //n
    return C;                                                 //1
  }                                                           //1
  //contador de frecuencia = 3n*2 + 2n + 8


  public static double[][] subtract(double[][] A, double[][] B) {  //1
    int m = A.length;                                              //1
    int n = A[0].length;                                           //1
    double[][] C = new double[m][n];                               //1
    for (int i = 0; i < m; i++) {                                  //n+1
      for (int j = 0; j < n; j++) {                                //n*2+1
        C[i][j] = A[i][j] - B[i][j];                               //n*2
      }                                                            //n*2
    }                                                              //n
    return C;                                                      //1
  }                                                                //1
  //contador de frecuencia = 3n*2 + 2n + 8


  public static double[] multiply(double[][] A, double[] x) {                     //1
    int m = A.length;                                                             //1
    int n = A[0].length;                                                          //1
    if (x.length != n) throw new RuntimeException("Illegal matrix dimensions.");  //1
    double[] y = new double[m];                                                   //1
    for (int i = 0; i < m; i++) {                                                 //n+1
      for (int j = 0; j < n; j++) {                                               //n*2+1
        y[i] += A[i][j] * x[j];                                                   //n*2
      }                                                                           //n*2
    }                                                                             //n
    return y;                                                                     //1
  }                                                                               //1
  //contador de frecuencia = 3n*2 + 2n + 9


  public static double[] multiplies(double[] x, double[][] A) {                   //1
    int m = A.length;                                                             //1
    int n = A[0].length;                                                          //1
    if (x.length != m) throw new RuntimeException("Illegal matrix dimensions.");  //1
    double[] y = new double[n];                                                   //1
    for (intj = 0; j < n; j++) {                                                  //n+1
      for (int i = 0; i < m; i++) {                                               //n*2 + 1
        y[j] += A[i][j] * x[i];                                                   //n*2
      }                                                                           //n*2
    }                                                                             //n
    return y;                                                                     //1
  }                                                                               //1
    //contador de frecuencia = 3n*2 + 2n + 9

  public static void main(String[] args) {                //1
    StdOut.printin("D");                                  //1
    StdOut.printin("--------");                           //1
    double[][] d = {{1, 2, 3, }, {4, 5, 6}, {9, 1, 3 }};  //1
    StdArrayIO.print(d);                                  //1
    StdOut.printLn();                                     //1

    StdOut.printLn("I");                                  //1
    StdOut.printLn("--------");                           //1
    double[][] c = Matrix.identity(5);                    //3n + 6
    StdArrayIO.print(c);                                  //1
    StdOut.printLn();                                     //1

    StdOut.printLn("A");                                  //1
    StdOut.printLn("--------");                           //1
    double[][] a = Matrix.random(5, 5);                   //3n*2 + 2n + 7
    StdArrayIO.print(a);                                  //1
    StdOut.printLn();                                     //1

    StdOut.printin("A^T");                                //1
    StdOut.printLn("--------");                           //1
    double[][] b = Matrix.transpose(a);                   //3n*2 +2n + 9
    StdArrayIO.print(b);                                  //1
    StdOut.printLn();                                     //1

    StdOut.printin("A + A^T");                            //1
    StdOut.printLn("--------");                           //1
    double[][] e = Matrix.add(a, b);                      //3n*2 + 2n + 8
    StdArraylO.print(e);                                  //1
    StdOut.printLn();                                     //1

    StdOut.printin("A * A^T");                            //1
    StdOut.printLn("--------");                           //1
    double[][] f = Matrix.multiply(a, b);                 //3n*2 + 2n + 9
    StdArrayIO.print(f);                                  //1
    StdOut.printLn();                                     //1
  }                                                       //1
    //contador de frecuencia = 12n*2 + 11n + 66
    //O (n*2)
}
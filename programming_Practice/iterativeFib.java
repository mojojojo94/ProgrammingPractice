public static int fib(int n){
        
        int a = 0;
        int b = 1;
        int temp = 0;
        
        for (int i = 2; i <= n ; i++){
            temp = a + b;
            //System.out.println("this is temp: " + temp);
            a = b;
            //System.out.println("this is a: " + a);
            b = temp;
            //System.out.println("this is b: " + b);
        }
        return temp;
    }
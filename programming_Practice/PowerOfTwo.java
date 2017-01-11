	/*
     * checking if number is power of 2 using brute force
     * starts with 1, multiplying with 2 it will eventually be same as original number
     */
	private static boolean powerOfTwo(int number){
        int square = 1;
        while(number >= square){
            if(number == square){
                return true;
            }
            square = square*2;
        }
        return false;
    }
  
    /*
     * find if an integer number is power of 2 or not using bit shift operator
     */
  
    private static boolean checkPowerOfTwo(int number){
         if(number <0){
            throw new IllegalArgumentException("number: " + number);
        }
        return ((number & (number -1)) == 0);
    }
def fib(n):
   """Recursive function to
   print Fibonacci sequence"""
   if n <= 2:
       return 1
   else:
       return(fib(n-1) + fib(n-2))
public class MyClass {
    public int MyMethod(int a, int b) {
        int result = 0;
        while (a > 0 && b > 0) {
            result++;
            a--;
            b--;
        }
        return result + a + b; 
    }
}
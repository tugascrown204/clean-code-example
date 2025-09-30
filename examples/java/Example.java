public class Example {
    /**
     * Calculate the area of a circle given the radius.
     * 
     * @param radius The radius of the circle.
     * @return The area of the circle.
     */
    public static double calculateAreaOfCircle(double radius) {
        final double PI = Math.PI;
        return PI * Math.pow(radius, 2);
    }

    public static void main(String[] args) {
        double radius = 5.0;
        double area = calculateAreaOfCircle(radius);
        System.out.printf("The area of the circle with radius %.2f is %.2f%n", radius, area);
    }
}

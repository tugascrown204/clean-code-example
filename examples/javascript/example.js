function calculateAreaOfCircle(radius) {
    /**
     * Calculate the area of a circle given the radius.
     * @param {number} radius - The radius of the circle.
     * @returns {number} The area of the circle.
     */
    const PI = Math.PI;
    return PI * Math.pow(radius, 2);
}

const radius = 5;
const area = calculateAreaOfCircle(radius);
console.log(`The area of the circle with radius ${radius} is ${area.toFixed(2)}`);

def calculate_area_of_circle(radius):
    """
    Calculate the area of a circle given the radius.
    :param radius: Radius of the circle.
    :return: Area of the circle.
    """
    import math
    return math.pi * (radius ** 2)

if __name__ == '__main__':
    radius = 5
    area = calculate_area_of_circle(radius)
    print(f'The area of the circle with radius {radius} is {area:.2f}')

import unittest

####################
# ASSIGNMENT START #
####################

from unittest import TestCase
import inspect

class Counter:
    total = 0
    found = 0
    extra = 0
    exceptions = 0

class YearHelper:
    cases = []
    exception_cases = []

    @staticmethod
    def leap_year(n):
        global cases
        global exception_cases

        if Counter.total == 0:
            cases = [1582, 1584, 1600, 1700]
            exception_cases = [1581]
            Counter.total = len(cases) + len(exception_cases)

        if n < 1582:
            if n in exception_cases:
                Counter.exceptions += 1
                exception_cases.remove(n)
            else:
                Counter.extra += 1
            raise ValueError()

        if n in cases:
            Counter.found += 1
            cases.remove(n)
        else:
            Counter.extra += 1

        if (n % 400 == 0):
            return True
        if (n % 100 == 0):
            return False
        if (n % 4 == 0):
            return True
        return False

class TestLeapYear(TestCase):
    ft = YearHelper()
    # example code
    # def test_year1(self):
    #   self.assertEqual(False, self.ft.leap_year(_year_))

    # Your code starts after this line
    def test_year1(self):
        self.assertRaises(ValueError, self.ft.leap_year, 1581)
    
    def test_year2(self):
        self.assertEqual(False, self.ft.leap_year(1582))

    def test_year3(self):
        self.assertEqual(True, self.ft.leap_year(1584))

    def test_year4(self):
        self.assertEqual(True, self.ft.leap_year(1600))

    def test_year5(self):
        self.assertEqual(False, self.ft.leap_year(1700))

    # Your code ends before this line

##################
# ASSIGNMENT END #
##################

if __name__ == "__main__":
    unittest.main()

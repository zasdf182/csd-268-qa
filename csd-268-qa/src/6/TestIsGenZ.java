import org.junit.jupiter.api.Assertions;
import java.util.ArrayList;

public class GenZTest {
    // Your code starts here

    // ##################################################################### //
    // ##################### BOUNDARY: INTEGER MINIMUM ##################### //
    // ##################################################################### //

    @org.junit.jupiter.api.Test
    public void testMethod1() {  
        IllegalArgumentException exception =
            Assertions.assertThrows(IllegalArgumentException.class, () -> {
                GenZHelper.IsGenZ(Integer.MIN_VALUE);
        });
    }

    @org.junit.jupiter.api.Test
    public void testMethod2(){  
        IllegalArgumentException exception =
            Assertions.assertThrows(IllegalArgumentException.class, () -> {
                GenZHelper.IsGenZ(Integer.MIN_VALUE + 1);
        });
    }

    // ##################################################################### //
    // ### BOUNDARY: 1582 (THE YEAR GREGORIAN CALENDAR WENT INTO EFFECT) ### //
    // ##################################################################### //

    @org.junit.jupiter.api.Test
    public void testMethod3(){  
        IllegalArgumentException exception =
            Assertions.assertThrows(IllegalArgumentException.class, () -> {
                GenZHelper.IsGenZ(1582 - 1);
        });
    }

    @org.junit.jupiter.api.Test
    public void testMethod4(){  
        Assertions.assertFalse(GenZHelper.IsGenZ(1582));
    }

    @org.junit.jupiter.api.Test
    public void testMethod5(){  
        Assertions.assertFalse(GenZHelper.IsGenZ(1582 + 1));
    }

    // ##################################################################### //
    // ############### BOUNDARY: 1997 (LOWER BOUND OF GEN Z) ############### //
    // ##################################################################### //

    @org.junit.jupiter.api.Test
    public void testMethod6(){  
        Assertions.assertFalse(GenZHelper.IsGenZ(1997 - 1));
    }

    @org.junit.jupiter.api.Test
    public void testMethod7(){  
        Assertions.assertTrue(GenZHelper.IsGenZ(1997));
    }

    @org.junit.jupiter.api.Test
    public void testMethod8(){  
        Assertions.assertTrue(GenZHelper.IsGenZ(1997 + 1));
    }

    // ##################################################################### //
    // ############### BOUNDARY: 2015 (UPPER BOUND OF GEN Z) ############### //
    // ##################################################################### //

    @org.junit.jupiter.api.Test
    public void testMethod9(){  
        Assertions.assertTrue(GenZHelper.IsGenZ(2015 - 1));
    }

    @org.junit.jupiter.api.Test
    public void testMethod10(){  
        Assertions.assertTrue(GenZHelper.IsGenZ(2015));
    }

    @org.junit.jupiter.api.Test
    public void testMethod11(){  
        Assertions.assertFalse(GenZHelper.IsGenZ(2015 + 1));
    }

    // ##################################################################### //
    // ##################### BOUNDARY: INTEGER MAXIUMUM #################### //
    // ##################################################################### //

    @org.junit.jupiter.api.Test
    public void testMethod12(){  
        Assertions.assertFalse(GenZHelper.IsGenZ(Integer.MAX_VALUE - 1));
    }

    @org.junit.jupiter.api.Test
    public void testMethod13(){  
        Assertions.assertFalse(GenZHelper.IsGenZ(Integer.MAX_VALUE));
    }

    // Your code ends here
}

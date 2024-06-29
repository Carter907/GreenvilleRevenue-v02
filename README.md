```
BEGIN
CLASS Program
Main METHOD
        DECLARE STRING input
        DO
        
            printMenu();
            input = Console.ReadLine();

            if (input == "1")
            {
                printMoreContestants();
            }

         WHILE (input does not equal "2")

        PRINT
         - "Thank you for using the Greenville Revenue App, good-bye!"
    
    STATIC printMenu()
    
        PRINT MULTI LINES -
          "************************************
          *  The stars shine in Greenville.  *
          ************************************
          
          Please Enter the following number below from the following menu:
          
          1. CALCULATE Greenville Revenue Year-Over-Year
          2. Exit"

    STATIC printMoreContestants()
    
        VAR previousYear = CONVERT TO INT (PROMPT USER ("Please enter the contestants for the previous year"))
        VAR currYear = CONVERT TO INT (PROMPT USER("Please enter the contestants for this year"));
        PRINT FORMATTED: previousYear, currYear
          - "Last year's competition had {0} contestants, and this year's has {1} contestants"
        IF (currYear > previousYear)
            PRINT
              - "It is true that this year's competition is bigger than last year's."
        ELSE
            PRINT
              - "It is false that this year's competition is bigger than last year's."
    
END Program
END

```

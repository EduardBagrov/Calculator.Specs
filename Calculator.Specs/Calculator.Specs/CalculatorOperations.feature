Feature: Calculator
	I want to check the basic functionality of calculator in programmer mode
@addition
Scenario Outline: Adding two numbers
	Given I have a calculator
	When I add two numbers <a> and <b>
	Then The result should be <result> on the screen

Examples: 
	| case                  | a   | b    | result |
	| all positive          | 60  | 30   | 90     |
	| all negative          | -60 | -305 | -365   |
	| positive and negative | 88  | -12  | 76     |
	| any number and zero   | -5  | 0    | -5     |

@addition
Scenario Outline: Adding three numbers
	Given I have a calculator
	When I add three numbers <a> and <b> and <c>
	Then The result should be <result> on the screen

Examples: 
	| case                  | a   | b    | c   | result |
	| all positive          | 60  | 30   | 9   | 99     |
	| all negative          | -60 | -305 | -10 | -375   |
	| positive and negative | 88  | -12  | 100 | 176    |
	| any number and zero   | -5  | 0    | 5   | 0      |

@multiplication
Scenario Outline: Multiplying two numbers
	Given I have a calculator
	When I multiply two numbers <a> and <b>
	Then The result should be <result> on the screen

Examples: 
	| case                  | a   | b    | result |
	| all positive          | 60  | 30   | 1800   |
	| positive and negative | -88 | 12   | -1056  |
	| any number and zero   | -5  | 0    | 0      |

@multiplication
Scenario Outline: Multiplying three numbers
	Given I have a calculator
	When I multiply three numbers <a> and <b> and <c>
	Then The result should be <result> on the screen

Examples: 
	| case                  | a   | b    | c  | result |
	| all positive          | 60  | 30   | 9  | 16200  |
	| positive and negative | -88 | 12   | 9  | -9504  |
	| any numbers and zero  | -5  | 0    | 50 | 0      |

@subtraction
Scenario Outline: Subtracting two numbers
	Given I have a calculator
	When I subtract two numbers <a> and <b>
	Then The result should be <result> on the screen

Examples: 
	| case                  | a   | b  | result |
	| all positive          | 60  | 30 | 30     |
	| positive and negative | -88 | 12 | -100   |
	| any number and zero   | -5  | 0  | -5     |

@subtraction
Scenario Outline: Subtracting three numbers
	Given I have a calculator
	When I subtract three numbers <a> and <b> and <c>
	Then The result should be <result> on the screen

Examples: 
	| case                  | a   | b    | c   | result |
	| all positive          | 60  | 30   | 9   | 21     |
	| positive and negative | -88 | 12   | 100 | -200   |
	| any number and zero   | -5  | 0    | 5   | -10    |

@division
Scenario Outline: Dividing two numbers
	Given I have a calculator
	When I divide two numbers <a> and <b>
	Then The result should be <result> on the screen

Examples: 
	| case                                | a     | b     | result |
	| bigger divider residual is zero     | 60    | 30    | 2      |
	| smaller divider result is zero      | 60    | 305   | 0      |
	| bigger divider residual is non zero | 60    | 13    | 4      |
	| divider is zero                     | 0     | 10    | 0      |
	| two equal numbers                   | 10000 | 10000 | 1      |

@division_not_allowed
Scenario Outline: Dividing by zero
	Given I have a calculator
	When I divide two numbers <a> and <b>
	Then The result of division by zero is not allowed

Examples: 
	| case                                | a     | b     | result                |
	| divisior is zero                    | 88    | 0     | Cannot divide by zero |

li $a1, 5            
mul $s0, $a1, $a1    

li $a2, 4            
mul $s1, $a1, $a2    

sub $s1, $zero, $s1   

add $ra, $s0, $s1    
addi $ra, $ra, 7     
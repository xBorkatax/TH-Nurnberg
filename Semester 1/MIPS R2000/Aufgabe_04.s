li $t0, 5          
li $t1, 1         
li $t2, 1   

loop:
mul $t1, $t1, $t2 
addi $t2, $t2, 1  
bne $t2, $t0, loop


add $v0, $t1, $zero    
li $v0, 1 
syscall            

li $a0, 5            
mul $t0, $a0, $a0    

mul $t1, $a0, 2     
add $v0, $t0, $t1    
addi $v0, $v0, 3     


add $a0, $v0, $zero        
li $v0, 1            
syscall              
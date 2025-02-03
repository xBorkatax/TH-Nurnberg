ungerade:
li $v0, 1            
main:
li $t0, 12312        
li $t1, 2            
li $t4, 1            

div $t0, $t1         
mfhi $t2           

beq $t2, $t4, ungerade  #  ungerade
li $v0, 0            
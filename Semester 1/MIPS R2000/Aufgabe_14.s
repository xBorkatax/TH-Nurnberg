main:
    li $a0, 5           
    li $t0, 10          
    slt $t1, $a0, $t0   
    bne $t1, $zero, less_than_10 # 

#  x >= 10:
greater_or_equal:
    mult $a0, $a0       # $a0 * $a0 (x^2)
    mflo $t2           

    li $t4, 3           
    mult $a0, $t4       # $a0 * 3
    mflo $t3            

    add $v0, $t2, $t3   # $v0 = x^2 + 3x
    j print_result     

# x < 10:
less_than_10:
    li $t4, 2 

    mult $a0, $t4 
    mflo $t3 # $t3 = 2x

    addi $v0, $t3, 5    # $v0 = 2x + 5


print_result:
    li $v0, 1           
    syscall          
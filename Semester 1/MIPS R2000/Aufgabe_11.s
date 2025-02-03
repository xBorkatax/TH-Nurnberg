li $a0, 4   

li $a1, -3         #  -3 
li $a2, 4          #  4 
li $a3, 6          #  6 

#  x^2
mult $a0, $a0
mflo $t0           # $t0 = x^2

#  -3 * x^2
mult $t0, $a1
mflo $t1           # $t1 = -3 * x^2

#  x^3
mult $a0, $t0
mflo $t2           # $t2 = x^3

#  4 * x^3
mult $t2, $a2
mflo $t3           # $t3 = 4 * x^3

#  6 * x
mult $a0, $a3
mflo $t4           # $t4 = 6 * x


add $v0, $t3, $t1  # $v0 = 4 * x^3 - 3 * x^2
add $v0, $v0, $t4  # $v0 = 4 * x^3 - 3 * x^2 + 6 * x
addi $v0, $v0, -2  # $v0 = 4 * x^3 - 3 * x^2 + 6 * x - 2
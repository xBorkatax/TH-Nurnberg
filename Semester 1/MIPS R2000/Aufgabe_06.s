main:
li $t0, 1
li $t1, 0
li $t2, 10

loop:
add $t1, $t1, $t0
addi $t0, $t0, 1
bne $t2, $t0, loop

add $v0, $t2, $zero
main:
	la $a0, 0x2000
	la $a1, 0x4000
	jal swap
swap:
	lw $t0, 0($a0)
	lw $t1, 0($a1)
	sw $t0, 0($a1)
	sw $t1, 0($a0)	
	jr $ra

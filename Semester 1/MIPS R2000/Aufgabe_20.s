	.data
hextab:
	.ascii "0123456789ABCDEF"
	.text
convhex:
	la $t0, hextab
	addiu $t1, $a1, 7
	add $t2, $a0, $zero
	addi $t3, $a1, -1
schleife:
	andi $t4, $t2, 0x000f
	addu $t4, $t4, $t0
	lb $t5, 0($t4)
	sb $t5, 0($t1)
	srl $t2, $t2, 4
	addi $t1, $t1, -1
	bne $t1, $t3, schleife
	jr $ra

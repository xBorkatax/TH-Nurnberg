        .text
	la $t1, a
	li $t0, 0
	li $v0, 0
weiter:
	beq $t0, $a0, ende
	sll $t2, $t0, 2
	add $t2, $t2, $t1 
	lw $t3, 0($t2)
	add $v0, $v0, $t3
	addi $t0, $t0, 1
	jal weiter
ende:	
	nop
	nop
	.data
a:
        .word 0x00001234
        .word 0x56780000
        .word 0x10203040
        .word 0x90807060

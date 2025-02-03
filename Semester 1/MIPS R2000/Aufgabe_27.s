main:
	la $t0, 0x2000
	lw $a0, 0x2000($t0)
	la $t0, 0x4000
	lw $a1, 0x2000($t0)
	jal max
max:
	slt $t0, $a0, $a1
	bne $t0, $zero, other
	add $v0, $a0, $zero
	jal final
other:
	add $v0, $a1, $zero
final:
	jr $ra
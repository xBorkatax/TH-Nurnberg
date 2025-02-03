.text

loop:

	lw     $2, 0x2000($0)
	sw     $2, 0x2004($0)

	beq    $0, $0, loop
	nop

.data
.org	0x2000

src_val:
	.word  0x12345678
dst_val:
	.word  0


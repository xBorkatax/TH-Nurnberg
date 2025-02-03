.text
	la   $t0,feld
	sll  $t1,$a0,2
	add  $t1,$t1,$t0
	lw   $t3,0($t1) 

.data
feld:	
	.word 0x00001234
	.word 0x56780000
	.word 0x10203040
	.word 0x90807060	

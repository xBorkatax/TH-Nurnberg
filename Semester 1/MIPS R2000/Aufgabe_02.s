.data
feld:
    .word 0x00001234  
    .word 0x56780000 
    .word 0x10203040  
    .word 0x90807060  

.text
main:
    la $t0, feld      
    lw $t1, 0($t0)    
    lw $t2, 4($t0)   
    lw $t3, 8($t0)    
    lw $t4, 12($t0)   
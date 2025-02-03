.data
wert: .word 0xffff8000  

.text
main:
    la $t1, wert      
    lw $t2, 0($t1)      
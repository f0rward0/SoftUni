package com.company;

/**
 * Created by Velkata on 12.11.2015 г..
 */
public class rational {
    private int numerator,denominator;

    public rational(int numerator, int denominator)
            throws RationalNumberException{
        this.numerator = numerator;
        this.denominator = denominator;

        if(denominator<=0)
            throw new RationalNumberException("SDASdasD");
        if(numerator!=0)
            reduce();
    }

    private void reduce(){
        int common=gcd (Math.abs(numerator),denominator);
        numerator/=common;
        denominator/=common;
    }

    private int gcd(int n1,int n2){
        while(n1!=n2)
            if(n1>n2)
                n1-=n2;
            else
                n2-=n1;

            return n1;

    }

    @Override
    public String toString() {
        return numerator + "/" + denominator;
    }

    public static rational add(rational op1,rational op2)throws RationalNumberException{
        int commonDenominator=op1.denominator*op2.denominator;
        int sum=op1.numerator*op2.denominator;

        return new rational(sum,commonDenominator);
    }
}

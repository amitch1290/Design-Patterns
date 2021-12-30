package com.techprimers.designpatterns.facade;

public class FacadePhone 
{

    private IPhone iPhone;
    private NokiaPhone nokiaPhone;
    private OnePlus onePlus;

    public FacadePhone() 
    {
        iPhone = new IPhone();
        nokiaPhone = new NokiaPhone();
        onePlus = new OnePlus();
    }

    public String buildApplePhone() 
    {
        return iPhone.build();
    }

    public String buildMicrosoftPhone() 
    {
        return nokiaPhone.build();
    }

    public String buildAndroidPhone()
    {
        return onePlus.build();
    }

public class IPhone implements Phone 
 {
    @Override
    public String build() 
    {
        return "Built using iOS 11";
    }
 }
public class NokiaPhone implements Phone 
 {
    @Override
    public String build() 
    {
        return "Built using Microsoft OS";
    }
 }
public class OnePlus implements Phone {
    @Override
    public String build() {
        return "Built using Android 4.0";
    }
}

public interface Phone 
 {
    String build();
 }

}

public class FacadeDemo {

    public static void main(String[] args) {

        FacadePhone facadePhone = new FacadePhone();

        System.out.println(facadePhone.buildAndroidPhone());
        System.out.println(facadePhone.buildApplePhone());
        System.out.println(facadePhone.buildMicrosoftPhone());

    }
}
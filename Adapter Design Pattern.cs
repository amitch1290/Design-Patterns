package com.techprimers.designpatterns.adapter;

public class AdapterExample {

    public static void main(String[] args) {

        AndroidCharger androidCharger = new AndroidCharger();
        AndroidPhone androidPhone = new OnePlus5();
        androidCharger.charge(androidPhone);

        IPhoneCharger iPhoneCharger = new IPhoneCharger();
        IPhone iPhone = new IPhoneX();
        iPhoneCharger.charge(iPhone);

        AndroidToIPhoneAdapter adapter = new AndroidToIPhoneAdapter(androidPhone);
        iPhoneCharger.charge(adapter);


    }
}

public class AndroidCharger {
    public void charge(AndroidPhone androidPhone) {
        androidPhone.charge();
    }
} 

public interface AndroidPhone {
    void charge();
} 

public class AndroidToIPhoneAdapter implements IPhone {

    AndroidPhone androidPhone;

    public AndroidToIPhoneAdapter(AndroidPhone androidPhone) {
        this.androidPhone = androidPhone;
    }

    public void charge() {
        androidPhone.charge();
    }
}

public interface IPhone {
    void charge();
}
 
public class IPhoneCharger {

    public void charge(IPhone iPhone){
        iPhone.charge();
    }
}

public class IPhoneX implements IPhone {
    public void charge() {
        System.out.println("Charging IPhone X");
    }
} 

public class OnePlus5 implements AndroidPhone {
    public void charge() {
        System.out.println("Charging OP5");
    }
}
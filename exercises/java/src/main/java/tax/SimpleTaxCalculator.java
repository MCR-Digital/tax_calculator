package tax;

public class SimpleTaxCalculator extends TaxCalculator {

    @Override
    int calculateTax(Vehicle vehicle) {
        int emissions = vehicle.getCo2Emissions();

        if (emissions == 0) {
            return 0;
        }
        if (emissions <= 50 && emissions > 0) {
            return 10;
        } else if (emissions > 50 && emissions <= 75) {
            return 25;
        } else if (emissions > 75 && emissions <= 90) {
            return 105;
        } else if (emissions > 90 && emissions <= 100) {
            return 125;
        } else if (emissions > 100 && emissions <= 110) {
            return 145;
        } else if (emissions > 110 && emissions <= 130) {
            return 165;
        } else if (emissions > 130 && emissions <= 150) {
            return 205;
        } else if (emissions > 150 && emissions <= 170) {
            return 515;
        } else if (emissions > 170 && emissions <= 190) {
            return 830;
        } else if (emissions > 190 && emissions <= 225) {
            return 1240;
        } else if (emissions <= 255 && emissions > 225) {
            return 1760;
        } else if (emissions > 255) {
            return 2070;
        }

        return -1;
    }
}

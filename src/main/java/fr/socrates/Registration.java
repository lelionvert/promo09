package fr.socrates;

class Registration {

    public int calculatePrice(Room room) {
        if (room.equals(Room.DOUBLE))
            return 750;
        return 850;
    }
}


#include "CoppeliaSimCSharpAPI.TestConsole.h"

using namespace std;

int main() {
    string command = "";

    cout << "CoppeliaSim C# API Test Console\n\n";
    while (true) {
        cin >> command;
        if (command == COMMAND_CONNECT) {
            //Connect("127.0.0.1", 3000);
        }
        else if (command == COMMAND_DISCONNECT) {
        }
        else if (command == COMMAND_EXIT) {
            break;
        }
        else {

        }
        cout << "\n";
    }
    return 0;
}


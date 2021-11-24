
#include "CoppeliaSimCSharpAPI.TestConsole.h"

using namespace std;

int main() {
    string command = "";

    cout << "CoppeliaSim C# API Test Console\n\n";
    while (true) {
        cin >> command;
        if (command == COMMAND_CONNECT) {

        }
        else if (command == COMMAND_DISCONNECT) {

        }
        else if (command == COMMAND_EXIT) {
            break;
        }
        else {

        }
    }
    return 0;
}

